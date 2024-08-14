using AutoMapper;
using BLL.AbstractServices;
using BLL.Dtos;
using Microsoft.AspNetCore.Mvc;
using MVCHambugerProjesi.Models;
using Newtonsoft.Json;

namespace MVCHambugerProjesi.Controllers
{
    public class OrderController : Controller
    {
        private readonly IUserService _userService;
        private readonly IOrderService _orderService;
        private readonly IMenuService _menuService;
        private readonly IExtraItemService _extraItemService;
        private readonly IMapper _mapper;

        public OrderController(IUserService userService, IOrderService orderService, IMenuService menuService, IExtraItemService extraItemService, IMapper mapper)
        {
            _userService = userService;
            _orderService = orderService;
            _menuService = menuService;
            _extraItemService = extraItemService;
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<IActionResult> Submit(string orderData)
        {
            var items = JsonConvert.DeserializeObject<List<ShoppingItem>>(orderData);

            // Toplam miktar hesaplanması
            double totalAmount = 0;
            foreach (var item in items)
            {
                totalAmount += Convert.ToDouble(item.Price.Replace("$", "")); // ₺5.99
            }

            ViewBag.TotalAmount = totalAmount;

            // Giriş yapmış kullanıcının adresleri
            var loggedInUserId = HttpContext.Session.GetInt32("UserId").Value;
            var users = await _userService.GetAllWithIncludesUsers();
            var user = users.FirstOrDefault(x => x.Id == loggedInUserId);
            var userViewModel = _mapper.Map<UserViewModel>(user);
            var userAddresses = userViewModel.AddressViewModels;
            ViewBag.UserAddresses = userAddresses;


            TempData["OrderData"] = JsonConvert.SerializeObject(items);

            return View(items); // Order/Submit.cshtml adlı view'a yönlendir
        }
        
        [HttpPost]
        public async Task<IActionResult> CreateOrder(int addressId, double totalPrice)
        {
            var orderData = TempData["OrderData"] as string;
            var shoppingItems = JsonConvert.DeserializeObject<List<ShoppingItem>>(orderData);

            int userAdressId = addressId;
            int userId = HttpContext.Session.GetInt32("UserId").Value;

            // Menü ve ekstra ürünleri ayır
            var menuItem = shoppingItems.FirstOrDefault(x => x.Type == "Menu");
            var extraItems = shoppingItems.Where(x => x.Type == "ExtraItem").ToList();

            // Siparişi oluştur
            var newOrder = new OrderViewModel()
            {
                TotalPrice = totalPrice,
                UserId = userId,
                OrderSize = DAL.Enums.OrderSize.Small
            };

            //// Menü'nün OrderCount'ını arttır. -> Tracker hatası
            //var menuDtos = await _menuService.GetAllMenus();
            //var menuDto = menuDtos.FirstOrDefault(x => x.Id == menuItem.Id);
            //menuDto.OrderCount++;
            //await _menuService.UpdateMenu(menuDto.Id, menuDto);


            var createdOrder = await _orderService.CreateNewOrder(_mapper.Map<OrderDto>(newOrder));
            int orderId = createdOrder.Id;

            if (menuItem != null)
            {
                if (extraItems.Count > 0)
                {
                    // Aynı Id'ye sahip ExtraItem'ları gruplandır
                    var groupedExtraItems = extraItems.GroupBy(x => x.Id);

                    foreach (var group in groupedExtraItems)
                    {
                        var newOrderDetail = new OrderDetailViewModel()
                        {
                            OrderId = orderId,
                            AddressId = addressId,
                            ExtraItemId = group.Key,
                            MenuId = menuItem.Id,
                            Quantity = group.Count()
                        };

                        await _orderService.CreateNewOrderDetail(_mapper.Map<OrderDetailDto>(newOrderDetail));
                    }
                }
                else
                {
                    var newOrderDetail = new OrderDetailViewModel()
                    {
                        OrderId = orderId,
                        AddressId = addressId,
                        MenuId = menuItem.Id,
                        Quantity = 1
                    };

                    await _orderService.CreateNewOrderDetail(_mapper.Map<OrderDetailDto>(newOrderDetail));
                }
              
            }
          

            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public IActionResult UserOrderDetails(int id)
        {
            var orderDetailDtos =  _orderService.GetAllOrderDetailsWithIncludes();


            var userOrderDetailDtos = orderDetailDtos.Where(x => x.OrderId == id).ToList();
            var userOrderDetailVieWModels = _mapper.Map<List<OrderDetailViewModel>>(userOrderDetailDtos);


            // User'ın verdiği Siparişin ExtraItem Name'leri
            List<string> extraItemNames = new List<string>(); 
            
            foreach (var item in userOrderDetailVieWModels)
            {
                if (item.ExtraItemViewModel != null)
                {
                    extraItemNames.Add(item.ExtraItemViewModel.Name);
                }
            }

            ViewBag.ExtraItemNames = extraItemNames;

            return View(userOrderDetailVieWModels);
        }

    }
}

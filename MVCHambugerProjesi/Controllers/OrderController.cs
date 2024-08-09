using AutoMapper;
using BLL.AbstractServices;
using Microsoft.AspNetCore.Mvc;
using MVCHambugerProjesi.Models;
using Newtonsoft.Json;

namespace MVCHambugerProjesi.Controllers
{
    public class OrderController : Controller
    {
        private readonly IUserService _userService;
        private readonly IOrderService _orderService;
        private readonly IMapper _mapper;

        public OrderController(IUserService userService, IOrderService orderService, IMapper mapper)
        {
            _userService = userService;
            _orderService = orderService;
            _mapper = mapper;
        }
        public async Task<IActionResult> Submit(string orderData)
        {
            var items = JsonConvert.DeserializeObject<List<ShoppingItem>>(orderData);

            // Toplam miktar hesaplanması
            double totalAmount = 0;
            foreach (var item in items)
            {
                totalAmount += Convert.ToDouble(item.Price.Replace("₺","")); // ₺5.99
            }

            ViewBag.TotalAmount = totalAmount;

            // Giriş yapmış kullanıcının adresleri
            var loggedInUserId = HttpContext.Session.GetInt32("UserId").Value;
            var users = await _userService.GetAllWithIncludesUsers();
            var user = users.FirstOrDefault(x => x.Id == loggedInUserId);
            var userViewModel = _mapper.Map<UserViewModel>(user);
            var userAddresses = userViewModel.AddressViewModels;
            ViewBag.UserAddresses = userAddresses;

            return View(items); // Order/Submit.cshtml adlı view'a yönlendir
        }

    }
}

using AutoMapper;
using BLL.AbstractServices;
using BLL.Dtos;
using Microsoft.AspNetCore.Mvc;
using MVCHambugerProjesi.Models;

namespace MVCHambugerProjesi.Controllers
{
    public class AdminController : Controller
    {
        private readonly IMenuService _menuService;
        private readonly IExtraItemService _extraItemService;
        private readonly IMenuDetailService _menuDetailService;
        private readonly IMapper _mapper;

        public AdminController(IMenuService menuService, IExtraItemService extraItemService, IMenuDetailService menuDetailService, IMapper mapper)
        {
            _menuService = menuService;
            _extraItemService = extraItemService;
            _menuDetailService = menuDetailService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult AddNewMenu()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddNewMenu(MenuViewModel menuViewModel)
        {
            if (menuViewModel.PhotoUrl != null)
            {
                var fileName = Path.GetFileName(menuViewModel.PhotoUrl.FileName);
                var filePath = Path.Combine("wwwroot", "img", fileName);

                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    await menuViewModel.PhotoUrl.CopyToAsync(stream);
                }

                menuViewModel.Photo = fileName;
            }
            if (ModelState.IsValid)
            {
                await _menuService.AddMenu(_mapper.Map<MenuDto>(menuViewModel));
                return RedirectToAction("Index", "Home");
            }


            return View(menuViewModel);
        }

        [HttpGet]
        public async Task<IActionResult> AddNewExtraItem()
        {
            var menuDtos = await _menuService.GetAllMenus();
            var menuViewModels = _mapper.Map<List<MenuViewModel>>(menuDtos);
            ViewBag.Menus = menuViewModels;
            
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddNewExtraItem(ExtraItemViewModel extraItemViewModel, int menuId)
        {
            if (ModelState.IsValid)
            {
                // ExtraItemDto'yu oluştur
                var extraItemDto = _mapper.Map<ExtraItemDto>(extraItemViewModel);

                // Yeni ExtraItem'ı ekle ve dönen ID'yi al
                var newExtraItem = await _extraItemService.AddExtraItem(extraItemDto);

                // MenuDetail'ı ekleyin
                await _menuDetailService.AddMenuDetail(newExtraItem.Id , menuId);

                return RedirectToAction("Index", "Home");
            }

            return View(extraItemViewModel);
        }

    }
}

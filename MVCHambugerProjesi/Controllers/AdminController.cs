using AutoMapper;
using BLL.AbstractServices;
using BLL.Dtos;
using DAL.Entities;
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
        public async Task<IActionResult> MenuAndExtraItemList()
        {
            var menuDtos = await _menuService.GetAllMenus();
            var menuViewModels = _mapper.Map<List<MenuViewModel>>(menuDtos);
            ViewBag.MenuViewModels = menuViewModels;


            var extraItemDtos = await _extraItemService.GetAllExtraItemsWithIncludes();
            var extraItemViewModels = _mapper.Map<List<ExtraItemViewModel>>(extraItemDtos);
            //ViewBag.ExtraItemViewModels = extraItemViewModels;


            var menuDetailDtos = await _menuService.GetAllMenuDetails();
            var menuDetailViewModels = _mapper.Map<List<MenuDetailViewModel>>(menuDetailDtos);
            ViewBag.MenuDetailViewModels = menuDetailViewModels;

            return View(extraItemViewModels);
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
                await _menuDetailService.AddMenuDetail(newExtraItem.Id, menuId);

                return RedirectToAction("Index", "Home");
            }

            return View(extraItemViewModel);
        }


        [HttpGet]
        public async Task<IActionResult> UpdateMenu(int id)
        {
            var menuDtos = await _menuService.GetAllMenus();
            var menu = menuDtos.FirstOrDefault(x => x.Id == id);
            var menuViewModel = _mapper.Map<MenuViewModel>(menu);

            return View(menuViewModel);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateMenu(int id, MenuViewModel menuViewModel)
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
            var menuDto = _mapper.Map<MenuDto>(menuViewModel);
            await _menuService.UpdateMenu(id, menuDto);

            return RedirectToAction("MenuAndExtraItemList");
        }

        [HttpGet]
        public async Task<IActionResult> UpdateExtraItem(int id)
        {
            var extraDtos = await _extraItemService.GetAllExtraItems();
            var extraItemDto = extraDtos.FirstOrDefault(x => x.Id == id);
            var extraItemViewModel = _mapper.Map<ExtraItemViewModel>(extraItemDto);

            return View(extraItemViewModel);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateExtraItem(int id, ExtraItemViewModel extraItemViewModel)
        {

            var extraDto = _mapper.Map<ExtraItemDto>(extraItemViewModel);
            await _extraItemService.UpdateExtraItem(id, extraDto);

            return RedirectToAction("MenuAndExtraItemList");
        }


        public async Task<IActionResult> DeleteMenu(int id)
        {
            // Tracker hatası!!
            //var menuDetailDtos = await _menuDetailService.GettAllMenuDetails();
            //var menuDetailByMenuIds = menuDetailDtos.Where(x => x.MenuId == id).Select(x => x.Id).ToList();

            //if (menuDetailByMenuIds.Any())
            //{
            //    await _menuDetailService.DeleteRangeAsync(menuDetailByMenuIds);
            //}

            // Menüyü sil
            await _menuService.DeleteMenu(id);

            return RedirectToAction("MenuAndExtraItemList");
        }


        public async Task<IActionResult> DeleteExtraItem(int id)
        {
            // Tracker Hatası!!
            //var menuDetailDtos = await _menuDetailService.GettAllMenuDetails();
            //var menuDetailByExtraItemIds = menuDetailDtos.Where(x => x.ExtraItemId == id).ToList();

            //if (menuDetailByExtraItemIds != null && menuDetailByExtraItemIds.Any())
            //{
            //    // Tüm MenuDetail kayıtlarını sil
            //    foreach (var menuDetail in menuDetailByExtraItemIds)
            //    {
            //        await _menuDetailService.DeleteMenuDetail(menuDetail.Id);
            //    }
            //}

            await _extraItemService.DeleteExtraItem(id);

            return RedirectToAction("MenuAndExtraItemList");
        }

        
        [HttpGet]
        public async Task<IActionResult> AddExtraItemToMenu(int id)
        {
            var menuDtos = await _menuService.GetAllMenus();
            var menu = menuDtos.FirstOrDefault(x => x.Id == id);
            var menuViewModel = _mapper.Map<MenuViewModel>(menu);

            var extraItemDtos = await _extraItemService.GetAllExtraItemsWithIncludes();
            var extraItemViewModels = _mapper.Map<List<ExtraItemViewModel>>(extraItemDtos);
            ViewBag.ExtraItemViewModels = extraItemViewModels;

            return View(menuViewModel);
        }

        [HttpPost]
        public async Task<IActionResult> AddExtraItemToMenu(int id, int extraItemId)
        {
            await _menuDetailService.AddMenuDetail(extraItemId, id);

            return RedirectToAction("MenuAndExtraItemList");
        }

        [HttpPost]
        public async Task<IActionResult> DeleteExtraItemToMenu(int id, int extraItemId)
        {
            var menuDetailDtos = await _menuDetailService.GettAllMenuDetails();
            var menuDetailDto = menuDetailDtos.FirstOrDefault(x => x.MenuId == id && x.ExtraItemId == extraItemId);


            await _menuDetailService.DeleteMenuDetail(menuDetailDto.Id);

            return RedirectToAction("MenuAndExtraItemList");
        }
    }
}

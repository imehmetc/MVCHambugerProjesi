using AutoMapper;
using BLL.AbstractServices;
using BLL.ConcreteServices;
using BLL.Dtos;
using DAL.Entities;
using Microsoft.AspNetCore.Mvc;
using MVCHambugerProjesi.Models;
using System.Diagnostics;

namespace MVCHambugerProjesi.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IMenuService _menuService;
        private readonly IMapper _mapper;

        public HomeController(ILogger<HomeController> logger, IMenuService menuService, IMapper mapper)
        {
            _logger = logger;
            _menuService = menuService;
            _mapper = mapper;
        }

        public async Task<IActionResult> Index()
        {
            var menus = await _menuService.GetAllMenus();
            var result = _mapper.Map<List<MenuViewModel>>(menus);
            
            return View(result);
        }

        public async Task<IActionResult> MenuDetail(int id)
        {
            var menuDetailDtos = await _menuService.GetAllMenuDetails();

            var menuDetailDto = menuDetailDtos.FirstOrDefault(x => x.MenuId == id);

            if (menuDetailDto == null)
            {
                var menuDtos = await _menuService.GetAllMenus();
                var menuDto1 = menuDtos.FirstOrDefault(x => x.Id == id);

                var result1 = _mapper.Map<MenuViewModel>(menuDto1);

                ViewBag.ExtraItems = new List<ExtraItemViewModel>();

                return View(result1);

            }
            var menuDto = menuDetailDto.MenuDto;

            var result = _mapper.Map<MenuViewModel>(menuDto);

            // Menüye bağlı ExtraItem'lar
            List<ExtraItemDto> extraItems = new List<ExtraItemDto>();
            var extraItemDto = menuDetailDtos.Where(x => x.MenuId == id).ToList();
            foreach (var item in extraItemDto)
            {
                extraItems.Add(item.ExtraItemDto);
            }

            var mappedExtraItems = _mapper.Map<List<ExtraItemViewModel>>(extraItems);

            ViewBag.ExtraItems = mappedExtraItems;

            return View(result);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

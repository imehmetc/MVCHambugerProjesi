using AutoMapper;
using BLL.AbstractServices;
using BLL.Dtos;
using DAL.AbstractRepositories;
using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.ConcreteServices
{
    public class MenuService : IMenuService
    {
        private readonly IRepository<Menu> _menuRepository;
        private readonly IMapper _mapper;

        public MenuService(IRepository<Menu> menuRepository, IMapper mapper)
        {
            _menuRepository = menuRepository;
            _mapper = mapper;
        }

        public async Task AddMenu(MenuDto menuDto)
        {
            if (menuDto != null)
            {
                var menu = _mapper.Map<Menu>(menuDto);
                await _menuRepository.AddAsync(menu);
            }
        }

        public async Task DeleteMenu(int menuId)
        {
            if(menuId != null)
                await _menuRepository.DeleteAsync(menuId);
        }

        public async Task<List<MenuDto>> GetAllMenus()
        {
            var menus = await _menuRepository.GetAllAsync();
            return _mapper.Map<List<MenuDto>>(menus);
        }

        public async Task RemoveMenu(int menuId)
        {
            if (menuId != null)
                await _menuRepository.RemoveAsync(menuId);
        }

        public async Task UpdateMenu(int menuId, MenuDto menuDto)
        {
            var findedMenu = await _menuRepository.GetByIdAsync(menuId);

            // mapper ?
            findedMenu.Name = menuDto.Name;
            findedMenu.Price = menuDto.Price;
            if (menuDto.Photo != null)
                findedMenu.Photo = menuDto.Photo;
            findedMenu.Description = menuDto.Description;

            await _menuRepository.UpdateAsync(findedMenu);

        }
    }
}

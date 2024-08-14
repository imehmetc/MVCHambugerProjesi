using AutoMapper;
using BLL.AbstractServices;
using BLL.Dtos;
using DAL.AbstractRepositories;
using DAL.Entities;
using Microsoft.EntityFrameworkCore;
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
        private readonly IRepository<MenuDetail> _menuDetailRepository;

        public MenuService(IRepository<Menu> menuRepository, IMapper mapper, IRepository<MenuDetail> menuDetailRepository)
        {
            _menuRepository = menuRepository;
            _mapper = mapper;
            _menuDetailRepository = menuDetailRepository;
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

        public async Task<List<MenuDetailDto>> GetAllMenuDetails()
        {
            var menus = await _menuDetailRepository.GetAllWithIncludes(x => x.Menu, x => x.ExtraItem).Where(x => x.IsDeleted == false).ToListAsync();
            var result = _mapper.Map<List<MenuDetailDto>>(menus);
            
            return result;
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

        public async Task UpdateMenuViewCount(int menuId)
        {
            await _menuRepository.UpdateViewCount(menuId);
        }
    }
}

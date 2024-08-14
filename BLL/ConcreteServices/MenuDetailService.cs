using AutoMapper;
using BLL.AbstractServices;
using BLL.Dtos;
using DAL.AbstractRepositories;
using DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BLL.ConcreteServices
{
    public class MenuDetailService : IMenuDetailService
    {
        private readonly IRepository<MenuDetail> _menuDetailService;
        private readonly IRepository<Menu> _menuRepository;
        private readonly IRepository<ExtraItem> _extraItemRepository;
        private readonly IMapper _mapper;

        public MenuDetailService(IRepository<MenuDetail> menuDetailService, IRepository<Menu> menuRepository, IRepository<ExtraItem> extraItemRepository, IMapper mapper)
        {
            _menuDetailService = menuDetailService;
            _menuRepository = menuRepository;
            _extraItemRepository = extraItemRepository;
            _mapper = mapper;
        }

        public async Task AddMenuDetail(int extraItemId, int menuId)
        {
            var menuDetails = await _menuDetailService.GetAllAsync();

            if (!menuDetails.Any(x => x.MenuId == menuId && x.ExtraItemId == extraItemId))
            {
                var menuDetail = new MenuDetailDto()
                {
                    MenuId = menuId,
                    ExtraItemId = extraItemId
                };

                await _menuDetailService.AddAsync(_mapper.Map<MenuDetail>(menuDetail));
            }
        }

        public async Task<MenuDetailDto> GetMenuDetailById(int menuDetailId)
        {
            var menuDetail = await _menuDetailService.GetByIdAsync(menuDetailId);
            var menuDetailDto = _mapper.Map<MenuDetailDto>(menuDetail);

            return menuDetailDto;
        }

        public async Task DeleteMenuDetail(int menuDetailId)
        {
            if(menuDetailId != null)
                await _menuDetailService.DeleteAsync(menuDetailId);
        }

        public async Task DeleteRangeAsync(IEnumerable<int> ids)
        {
            await _menuDetailService.DeleteRangeAsync(ids);
        }

        public async Task<List<MenuDetailDto>> GettAllMenuDetails()
        {
            var menuDetails = await _menuDetailService.GetAllWithIncludes(x => x.Menu, x => x.ExtraItem).Where(x => x.IsDeleted == false).ToListAsync();
            
            return _mapper.Map<List<MenuDetailDto>>(menuDetails);
        }
        public async Task RemoveMenuDetail(int menuDetailId)
        {
            if (menuDetailId != null)
                await _menuDetailService.RemoveAsync(menuDetailId);
        }
    }
}

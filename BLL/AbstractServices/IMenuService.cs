using BLL.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.AbstractServices
{
    public interface IMenuService
    {
        Task AddMenu(MenuDto menuDto);
        Task RemoveMenu(int menuId);
        Task DeleteMenu(int menuId);
        Task<List<MenuDto>> GetAllMenus();
        Task UpdateMenu(int menuId, MenuDto menuDto);
        Task<List<MenuDetailDto>> GetAllMenuDetails();
    }
}

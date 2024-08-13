using BLL.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.AbstractServices
{
    public interface IMenuDetailService
    {
        Task AddMenuDetail(int extraItemId, int menuId);
        Task<List<MenuDetailDto>> GettAllMenuDetails();
        Task DeleteMenuDetail(int menuDetailId);
        Task RemoveMenuDetail(int menuDetailId);
        Task DeleteRangeAsync(IEnumerable<int> ids);
    }
}

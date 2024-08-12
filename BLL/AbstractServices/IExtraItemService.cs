using BLL.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.AbstractServices
{
    public interface IExtraItemService
    {
        Task<ExtraItemDto> AddExtraItem(ExtraItemDto extraItemDto);
        Task RemoveExtraItem(int extraItemId);
        Task DeleteExtraItem(int extraItemId);
        Task<List<ExtraItemDto>> GetAllExtraItems();
        Task UpdateExtraItem(int extraItemId, ExtraItemDto extraItemDto);
    }
}

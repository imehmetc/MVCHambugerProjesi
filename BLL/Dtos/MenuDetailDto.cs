using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Dtos
{
    public class MenuDetailDto : BaseDto
    {
        public int? ExtraItemId { get; set; }
        public int MenuId { get; set; }

        // Relational Properties
        public ExtraItemDto ExtraItemDto { get; set; }
        public MenuDto MenuDto { get; set; }
        public List<OrderDto> OrderDtos { get; set; }
    }
}

using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Dtos
{
    public class OrderDetailDto : BaseDto
    {
        public int AddressId { get; set; }
        public int ExtraItemId { get; set; }
        public int MenuId { get; set; }
        public int OrderId { get; set; }
        public int Quantity { get; set; }


        // Relational Properties
        public AddressDto AddressDto { get; set; }
        public ExtraItemDto ExtraItemDto { get; set; }
        public MenuDto MenuDto { get; set; }
        public OrderDto OrderDto { get; set; }
    }
}

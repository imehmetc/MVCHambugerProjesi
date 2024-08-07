using BLL.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Dtos
{
    public class OrderDto : BaseDto
    {
        public OrderSizeDto? OrderSizeDto { get; set; } // ENUM
        public int Quantity { get; set; }
        public int AddressId { get; set; }
        public int MenuDetailId { get; set; }
        public double TotalPrice { get; set; }
        
        // Relational Properties
        public AddressDto AddressDto { get; set; }
        public MenuDetailDto MenuDetailDto { get; set; }
    }
}

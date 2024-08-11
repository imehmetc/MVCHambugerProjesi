using BLL.Enums;
using DAL.Entities;
using DAL.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Dtos
{
    public class OrderDto : BaseDto
    {
        public OrderSize? OrderSize { get; set; } // ENUM
     
        public double TotalPrice { get; set; }
        public DateTime OrderDate { get; set; } = DateTime.Now;
        public bool IsActive { get; set; } = true;
        public int UserId { get; set; }


        // Relational Properties
        public List<OrderDetailDto> OrderDetailDtos { get; set; }
        public UserDto UserDto { get; set; }
    }
}

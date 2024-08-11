using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Dtos
{
    public class MenuDto : BaseDto
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public string? Photo { get; set; }
        public int OrderCount { get; set; }
        public int ViewCount { get; set; }

        // Relational Properties
        public List<MenuDetailDto> MenuDetailDtos { get; set; }
        public List<OrderDetailDto> OrderDetailDtos { get; set; }
    }
}

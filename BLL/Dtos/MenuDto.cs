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

        // Relational Properties
        public List<MenuDetailDto> MenuDetailDtos { get; set; }
    }
}

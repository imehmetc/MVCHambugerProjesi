using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Dtos
{
    public class ExtraItemDto : BaseDto
    {
        public string Name { get; set; }
        public double AdditionalPrice { get; set; }


        // Relational Properties
        public List<MenuDetailDto> MenuDetailDtos { get; set; }
        public List<OrderDetailDto> OrderDetailDtos { get; set; }
    }
}

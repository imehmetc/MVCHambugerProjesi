using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Dtos
{
    public class AddressDto : BaseDto
    {
        public string FullAddress { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public int PostalCode { get; set; }
        public int UserId { get; set; }

        // Relational Properties
        public UserDto User { get; set; }
        public List<OrderDto> OrderDtos { get; set; }
        public List<OrderDetailDto> OrderDetailDtos { get; set; }
    }
}

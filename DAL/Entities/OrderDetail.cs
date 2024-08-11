using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class OrderDetail : BaseEntity
    {
        public int AddressId { get; set; }
        public int ExtraItemId { get; set; }
        public int MenuId { get; set; }
        public int OrderId { get; set; }
        public int Quantity { get; set; }


        // Relational Properties
        public Address Address { get; set; }
        public ExtraItem ExtraItem { get; set; }
        public Menu Menu { get; set; }
        public Order Order { get; set; }
    }
}

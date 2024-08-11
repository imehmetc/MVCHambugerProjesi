using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Address : BaseEntity
    {
        public string FullAddress { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public int PostalCode { get; set; }
        public int UserId { get; set; }

        // Relational Properties
        public User User { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }
    }
}

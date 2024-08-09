using DAL.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Order : BaseEntity
    {
        public OrderSize? OrderSize { get; set; } // ENUM
        public int Quantity { get; set; }
        public int AddressId { get; set; }
        public int MenuDetailId { get; set; }
        public double TotalPrice { get; set; }


        // Relational Properties
        public Address Address { get; set; }
        public MenuDetail MenuDetail { get; set; }
    }
}

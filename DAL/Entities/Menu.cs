using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Menu : BaseEntity
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public string? Photo { get; set; }
        public int OrderCount { get; set; }
        public int ViewCount { get; set; }

        // Relational Properties
        public List<MenuDetail> MenuDetails { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }
    }
}

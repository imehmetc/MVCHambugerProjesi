using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class ExtraItem : BaseEntity
    {
        public string Name { get; set; }
        public double AdditionalPrice { get; set; }


        // Relational Properties
        public List<MenuDetail> MenuDetails { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }

    }
}

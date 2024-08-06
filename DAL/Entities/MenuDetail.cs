using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class MenuDetail : BaseEntity
    {
        public int? ExtraItemId { get; set; }
        public int MenuId { get; set; }

        // Relational Properties
        public ExtraItem ExtraItem { get; set; }
        public Menu Menu { get; set; }
    }
}

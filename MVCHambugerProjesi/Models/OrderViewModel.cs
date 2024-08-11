using DAL.Entities;
using DAL.Enums;
using MVCHambugerProjesi.Enums;

namespace MVCHambugerProjesi.Models
{
    public class OrderViewModel : BaseViewModel
    {
        public OrderSize? OrderSize { get; set; } // ENUM
       
        public double TotalPrice { get; set; }
        public DateTime OrderDate { get; set; } = DateTime.Now;
        public bool IsActive { get; set; } = true;
        public int UserId { get; set; }


        // Relational Properties
        public List<OrderDetailViewModel> OrderDetailViewModels { get; set; }
        public UserViewModel UserViewModel { get; set; }
    }
}

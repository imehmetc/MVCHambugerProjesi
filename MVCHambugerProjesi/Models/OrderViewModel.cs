using DAL.Entities;
using DAL.Enums;
using MVCHambugerProjesi.Enums;

namespace MVCHambugerProjesi.Models
{
    public class OrderViewModel : BaseViewModel
    {
        public OrderSizeViewModel? OrderSizeViewModel { get; set; } // ENUM
        public int Quantity { get; set; }
        public int AddressId { get; set; }
        public int MenuDetailId { get; set; }

        // Relational Properties
        public AddressViewModel AddressViewModel { get; set; }
        public MenuDetailViewModel MenuDetailViewModel { get; set; }
    }
}

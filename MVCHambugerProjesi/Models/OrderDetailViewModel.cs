using DAL.Entities;

namespace MVCHambugerProjesi.Models
{
    public class OrderDetailViewModel : BaseViewModel
    {
        public int AddressId { get; set; }
        public int? ExtraItemId { get; set; }
        public int MenuId { get; set; }
        public int OrderId { get; set; }
        public int Quantity { get; set; }


        // Relational Properties
        public AddressViewModel AddressViewModel { get; set; }
        public ExtraItemViewModel ExtraItemViewModel { get; set; }
        public MenuViewModel MenuViewModel { get; set; }
        public OrderViewModel OrderViewModel { get; set; }
    }
}

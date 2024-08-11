using DAL.Entities;

namespace MVCHambugerProjesi.Models
{
    public class ExtraItemViewModel : BaseViewModel
    {
        public string Name { get; set; }
        public double AdditionalPrice { get; set; }


        // Relational Properties
        public List<MenuDetailViewModel> MenuDetailViewModels { get; set; }
        public List<OrderDetailViewModel> OrderDetailViewModels { get; set; }
    }
}

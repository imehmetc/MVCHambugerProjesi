using DAL.Entities;

namespace MVCHambugerProjesi.Models
{
    public class MenuDetailViewModel : BaseViewModel
    {
        public int? ExtraItemId { get; set; }
        public int MenuId { get; set; }

        // Relational Properties
        public ExtraItemViewModel ExtraItemViewModel { get; set; }
        public MenuViewModel MenuViewModel { get; set; }
    }
}

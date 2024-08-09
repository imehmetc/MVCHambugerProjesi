using DAL.Entities;

namespace MVCHambugerProjesi.Models
{
    public class MenuViewModel : BaseViewModel
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public string? Photo { get; set; }
        public IFormFile? PhotoUrl { get; set; }
        public int OrderCount { get; set; }
        public int ViewCount { get; set; }

        // Relational Properties
        public List<MenuDetailViewModel> MenuDetailViewModels { get; set; }
    }
}

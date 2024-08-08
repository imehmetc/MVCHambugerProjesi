using BLL.Dtos;
using DAL.Entities;

namespace MVCHambugerProjesi.Models
{
    public class AddressViewModel : BaseViewModel
    {
        public string FullAddress { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public int PostalCode { get; set; }
        public int UserId { get; set; }

        // Relational Properties
        public UserViewModel UserViewModel { get; set; }
        public List<OrderViewModel> OrderViewModels { get; set; }
    }
}
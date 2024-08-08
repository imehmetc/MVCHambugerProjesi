using DAL.Entities;
using System.ComponentModel.DataAnnotations;

namespace MVCHambugerProjesi.Models
{
    public class UserViewModel : BaseViewModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string? Photo { get; set; }
        public IFormFile? PhotoUrl { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public bool IsAdmin { get; set; } = false;
        
        [Compare("Password", ErrorMessage = "Passwords do not match.")]
        public string ConfirmPassword { get; set; }

        // Relational Properties
        public List<AddressViewModel>? AddressViewModels { get; set; }
    }
}

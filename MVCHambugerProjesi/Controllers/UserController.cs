using AutoMapper;
using BLL.AbstractServices;
using BLL.Dtos;
using Microsoft.AspNetCore.Mvc;
using MVCHambugerProjesi.Models;
using MVCHambugerProjesi.StaticMethods;

namespace MVCHambugerProjesi.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserService _userService;
        private readonly IMapper _mapper;

        public UserController(IUserService userService, IMapper mapper)
        {
            _userService = userService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(string userName, string password)
        {
            var userDto =  await _userService.Login(userName, Sha256Hasher.ComputeSha256Hash(password));
            if (userDto != null)
            {
                var userViewModel = _mapper.Map<UserViewModel>(userDto);

                HttpContext.Session.SetInt32("UserId", userViewModel.Id);
                HttpContext.Session.SetString("UserName", userViewModel.Username);
                HttpContext.Session.SetString("IsAdmin", userViewModel.IsAdmin.ToString());

                return RedirectToAction("Index", "Home", userViewModel);
            }
            else
            {
                HttpContext.Session.SetInt32("UserId", 0);
                ViewBag.ErrorMessage = "Invalid username or password.";
            }

            return View();
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(UserViewModel userViewModel, string fullAddress, string city, string country, int postalCode)
        {
            if (userViewModel.PhotoUrl != null)
            {
                var fileName = Path.GetFileName(userViewModel.PhotoUrl.FileName);
                var filePath = Path.Combine("wwwroot", "img", fileName);

                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    await userViewModel.PhotoUrl.CopyToAsync(stream);
                }

                userViewModel.Photo = fileName;
            }

            if (ModelState.IsValid)
            {
                var users = await _userService.GetAllUsers();
                var existingUser = users.FirstOrDefault(x => x.Username == userViewModel.Username || x.Email == userViewModel.Email);
                
                // Username ve Email kontrolü
                if (existingUser != null)
                {
                    ViewBag.ErrorMessage = "Username or Email already exists.";
                    return View(userViewModel);
                }

                // Şifre eşleşmesi kontrolü
                if (userViewModel.Password != userViewModel.ConfirmPassword)
                {
                    ViewBag.ErrorMessage = "Passwords do not match.";
                    return View(userViewModel);
                }

                // Birthdate kontrolü
                if (userViewModel.BirthDate.Year == DateTime.Now.Year)
                {
                    ViewBag.ErrorMessage = "Your Birthdate cannot be today.";
                    return View(userViewModel);
                }

                // City kontrolü
                if (city == "default")
                {
                    ViewBag.ErrorMessage = "Please select a valid city";
                    return View(userViewModel);
                }

                // Address eklenmesi
                userViewModel.AddressViewModels = new List<AddressViewModel>
                    {
                        new AddressViewModel
                        {
                            FullAddress = fullAddress,
                            City = city,
                            Country = country,
                            PostalCode = postalCode,
                            UserId = userViewModel.Id
                        }
                    };

                // Password hash
                userViewModel.Password = Sha256Hasher.ComputeSha256Hash(userViewModel.Password);
                
                var userDto = _mapper.Map<UserDto>(userViewModel);
                await _userService.Register(userDto);
                return RedirectToAction("Login");
            }

            return View(userViewModel);
        }



        public IActionResult Logout()
        {
            HttpContext.Session.Clear();

            return RedirectToAction("Login", "User");
        }

        public async Task<IActionResult> Profile(int id)
        {
            var users = await _userService.GetAllUsers();

            UserDto user;

            if (id != 0)
                user = users.FirstOrDefault(x => x.Id == id && x.IsAdmin == false);
            else
                user = users.FirstOrDefault(x => x.Id == HttpContext.Session.GetInt32("UserId") && x.IsAdmin == false);

            if (user == null)
                return RedirectToAction("Index", "Home");

            var mappedUser = _mapper.Map<UserViewModel>(user);


            return View(mappedUser);
        }

        [HttpGet]
        public async Task<IActionResult> PasswordChange(int id)
        {
            var users = await _userService.GetAllUsers();

            var user = users.FirstOrDefault(x => x.Id == id);

            var userViewModel = _mapper.Map<UserViewModel>(user);

            return View(userViewModel);
            
        }

        [HttpPost] // Tracker hatası veriyor.
        public async Task<IActionResult> PasswordChange(int id, string newPassword, string newPasswordConfirm)
        {
            var users = await _userService.GetAllUsers();

            var user = users.FirstOrDefault(x => x.Id == id);

            var userViewModel = _mapper.Map<UserViewModel>(user);

            if (id != null)
            {
                if (newPassword == newPasswordConfirm)
                {
                    await _userService.PasswordChange(id, Sha256Hasher.ComputeSha256Hash(newPassword));
                    return RedirectToAction("Logout", "User");
                }
                else
                {
                    ViewBag.ErrorMessage = "Passwords do not match.";
                    return View(userViewModel);
                }
            }

            return View(userViewModel);
        }
    }
}

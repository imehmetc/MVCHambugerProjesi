using AutoMapper;
using BLL.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.AbstractServices
{
    public interface IUserService 
    {
        Task<UserDto> Login(string username, string password);
        Task Register(UserDto userDto);
        Task<List<UserDto>> GetAllUsers();
        Task<List<UserDto>> GetAllWithIncludesUsers();
        Task<UserDto> GetUserById(int id);
        Task PasswordChange(int userId, string newPassword);
        
        // kullanıcının siparişleri
    }
}

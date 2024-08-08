using AutoMapper;
using BLL.AbstractServices;
using BLL.Dtos;
using DAL.AbstractRepositories;
using DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.ConcreteServices
{
    public class UserService : IUserService
    {
        private readonly IRepository<User> _userRepository;
        private readonly IMapper _mapper;

        public UserService(IRepository<User> userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }
        public async Task<List<UserDto>> GetAllUsers()
        {
            var users = await _userRepository.GetAllAsync();
            var mappedUsers = _mapper.Map<List<UserDto>>(users);

            return mappedUsers;
        }

        public async Task<List<UserDto>> GetAllWithIncludesUsers()
        {
            var users = await _userRepository.GetAllWithIncludes().ToListAsync();
            var mappedUsers = _mapper.Map<List<UserDto>>(users);

            return mappedUsers;
        }

        public async Task<UserDto> GetUserById(int id)
        {
            var user = await _userRepository.GetByIdAsync(id);

            return _mapper.Map<UserDto>(user);
        }

        public async Task<UserDto> Login(string username, string password)
        {
            var users = await _userRepository.GetAllAsync();
            var user = users.FirstOrDefault(x => x.Username == username && x.Password == password);

            return _mapper.Map<UserDto>(user);
        }

        public async Task PasswordChange(int userId, string newPassword)
        {
            var user = await _userRepository.GetByIdAsync(userId);
            var userDto = _mapper.Map<UserDto>(user);

            userDto.Password = newPassword;
            await _userRepository.UpdateAsync(_mapper.Map<User>(userDto));
        }

        public async Task Register(UserDto userDto)
        {
            var user = _mapper.Map<User>(userDto);

            await _userRepository.AddAsync(user);
        }

    }
}

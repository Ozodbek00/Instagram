using Instagram.Api.Data.IRepositories;
using Instagram.Api.Domain.Entities;
using Instagram.Api.Helpers;
using Instagram.Api.Service.DTOs;
using Instagram.Api.Service.ServiceInterfaces;

namespace Instagram.Api.Service
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public User Create(UserForCreationDto userDto)
        {
            if (_userRepository.GetAll().Any(u => u.Nickname.Equals(userDto.Nickname)))
                throw new Exception("This nickname exists");

            User user = new()
            {
                Nickname = userDto.Nickname,
                Password = userDto.Password.Encrypt(),
                FirstName = userDto.FirstName,
                LastName = userDto.LastName,
                DateOfBirth = userDto.DateOfBirth,
                PhoneNumber = userDto.PhoneNumber,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            };

            _userRepository.Create(user);

            return user;
        }

        public bool Delete(long id)
        {
            var user = _userRepository.GetById(id);

            if (user != null)
            {
                return _userRepository.Delete(user);
            }

            throw new Exception("User does not exist");
        }

        public User GetById(long id)
        {
            return _userRepository.GetById(id);
        }

        public User[] GetUsers()
        {
            return _userRepository.GetAll().ToArray();
        }

        public User Update(long id, UserForUpdateDto userDto)
        {
            var user = _userRepository.GetById(id);

            if (user is null)
                throw new Exception("User does not exist");

            user.FirstName = userDto.FirstName;
            user.LastName = userDto.LastName;
            user.DateOfBirth = user.DateOfBirth;
            user.PhoneNumber = userDto.PhoneNumber;
            user.CreatedAt = user.CreatedAt;
            user.UpdatedAt = DateTime.UtcNow;
            user.Password = user.Password;
            user.Nickname = user.Nickname;

            _userRepository.Update(user);

            return user;
        }
    }
}

using Instagram.Api.Domain.Entities;
using Instagram.Api.Service.DTOs;

namespace Instagram.Api.Service.ServiceInterfaces
{
    public interface IUserService
    {
        public User Create(UserForCreationDto userDto);

        public User Update(long id, UserForUpdateDto userDto);

        public bool Delete(long id);

        public User GetById(long id);

        public User[] GetUsers();
    }
}

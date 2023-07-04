using Instagram.Api.Domain.Entities;

namespace Instagram.Api.Data.IRepositories
{
    public interface IUserRepository
    {
        public User Create(User user);

        public User Update(User user);

        public bool Delete(User user);

        public User GetById(long id);

        public IQueryable<User> GetAll();
    }
}

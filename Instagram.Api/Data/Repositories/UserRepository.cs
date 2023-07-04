using Instagram.Api.Data.DbContexts;
using Instagram.Api.Data.IRepositories;
using Instagram.Api.Domain.Entities;

namespace Instagram.Api.Data.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly AppDbContext _context;

        public UserRepository(AppDbContext context)
        {
            _context = context;
        }

        public User Create(User user)
        {
            _context.Users.Add(user);

            _context.SaveChanges();

            return user;
        }

        public bool Delete(User user)
        {
            _context.Users.Remove(user);

            if(_context.SaveChanges() == 0)
                return false;

            return true;
        }

        public IQueryable<User> GetAll()
        {
            return _context.Users;
        }

        public User GetById(long id)
        {
            return _context.Users.FirstOrDefault(u => u.Id == id);
        }

        public User Update(User user)
        {
            _context.Users.Update(user);

            _context.SaveChanges();

            return user;
        }
    }
}

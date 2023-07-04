using Instagram.Api.Data.DbContexts;
using Instagram.Api.Data.IRepositories;
using Instagram.Api.Domain.Entities;

namespace Instagram.Api.Data.Repositories
{
    public class PostRepository : IPostRepository
    {
        private readonly AppDbContext _context;

        public PostRepository(AppDbContext context)
        {
            _context = context;
        }

        public Post Create(Post Post)
        {
            _context.Posts.Add(Post);

            _context.SaveChanges();

            return Post;
        }

        public bool Delete(Post Post)
        {
            _context.Posts.Remove(Post);

            if (_context.SaveChanges() == 0)
                return false;

            return true;
        }

        public IQueryable<Post> GetAll()
        {
            return _context.Posts;
        }

        public Post GetById(long id)
        {
            return _context.Posts.FirstOrDefault(u => u.Id == id);
        }

        public Post Update(Post Post)
        {
            _context.Posts.Update(Post);

            _context.SaveChanges();

            return Post;
        }
    }
}

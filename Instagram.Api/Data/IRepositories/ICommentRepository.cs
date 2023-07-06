using Instagram.Api.Domain.Entities;

namespace Instagram.Api.Data.IRepositories
{
    public interface ICommentRepository
    {
        public Post Create(Post post);

        public Post Update(Post post);

        public bool Delete(Post post);

        public Post GetById(long id);

        public IQueryable<Post> GetAll();
    }
}

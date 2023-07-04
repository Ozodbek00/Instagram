using Instagram.Api.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Instagram.Api.Data.DbContexts
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }

        public DbSet<Attachment> Attachments { get; set; }

        public DbSet<Chat> Chats { get; set; }

        public DbSet<Comment> Comments { get; set; }

        public DbSet<Follower> Followers { get; set; }

        public DbSet<Message> Messages { get; set; }

        public DbSet<Post> Posts { get; set; }

        public DbSet<UserPost> UserPosts { get; set; }
    }
}

using System.ComponentModel.DataAnnotations.Schema;

namespace Instagram.Api.Domain.Entities
{
    public sealed class Post : BaseModel
    {
        public string Title { get; set; }

        public string Description { get; set; }

        public long UserId { get; set; }
        // comment
        [ForeignKey(nameof(UserId))]
        public User User { get; set; }
    }
}

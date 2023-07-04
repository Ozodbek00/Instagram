using System.ComponentModel.DataAnnotations.Schema;

namespace Instagram.Api.Domain.Entities
{
    public sealed class UserPost : BaseModel
    {
        public long UserId { get; set; }
        [ForeignKey(nameof(UserId))]
        public User User { get; set; }

        public long PostId { get; set; }
        [ForeignKey(nameof(PostId))]
        public Post Post { get; set; }

        public bool Liked { get; set; }

        public bool Saved { get; set; }

        public long? CommentId { get; set; }
        [ForeignKey(nameof(CommentId))]
        public Comment Comment { get; set; }
    }
}

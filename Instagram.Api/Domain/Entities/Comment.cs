using System.ComponentModel.DataAnnotations.Schema;

namespace Instagram.Api.Domain.Entities
{
    public class Comment : BaseModel
    {
        public string Text { get; set; }

        public long UserId { get; set; }
        [ForeignKey(nameof(UserId))]
        public User User { get; set; }

        public long PostId { get; set; }
        [ForeignKey(nameof(PostId))]
        public Post Post { get; set; }

        public long? ParentId { get; set; }
        [ForeignKey(nameof(ParentId))]
        public Comment Parent { get; set; }
    }
}

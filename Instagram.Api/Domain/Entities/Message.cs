using System.ComponentModel.DataAnnotations.Schema;

namespace Instagram.Api.Domain.Entities
{
    public class Message : BaseModel
    {
        public string Text { get; set; }

        public long UserId { get; set; }
        [ForeignKey(nameof(UserId))]
        public User User { get; set; }

        public long ChatId { get; set; }
        [ForeignKey(nameof(ChatId))]
        public Chat Chat { get; set; }
    }
}

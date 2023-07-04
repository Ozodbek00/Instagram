using System.ComponentModel.DataAnnotations.Schema;

namespace Instagram.Api.Domain.Entities
{
    public class Chat : BaseModel
    {
        public long User1Id { get; set; }
        [ForeignKey(nameof(User1Id))]
        public User User1 { get; set; }

        public long User2Id { get; set; }
        [ForeignKey(nameof(User2Id))]
        public User User2 { get; set; }
    }
}

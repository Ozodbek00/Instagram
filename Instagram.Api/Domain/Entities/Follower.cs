using System.ComponentModel.DataAnnotations.Schema;

namespace Instagram.Api.Domain.Entities
{
    public class Follower : BaseModel
    {
        public long ErgashuvchiId { get; set; }
        [ForeignKey(nameof(ErgashuvchiId))]
        public User Ergashuvchi { get; set; }

        public long FollowingId { get; set; }
        [ForeignKey(nameof(FollowingId))]
        public User Following { get; set; }
    }
}

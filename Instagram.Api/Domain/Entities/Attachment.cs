using System.ComponentModel.DataAnnotations.Schema;

namespace Instagram.Api.Domain.Entities
{
    public class Attachment : BaseModel
    {
        public string FileName { get; set; }

        public string FilePath { get; set; }

        public long PostId { get; set; }
        [ForeignKey(nameof(PostId))]
        public Post Post { get; set; }
    }
}

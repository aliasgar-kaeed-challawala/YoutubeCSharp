using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication3.Models
{
    public class User
    {
        public string UserId { get; set; }

        public string Email { get; set; }
        public string UserName { get; set; }
        public string ProfileImg { get; set; }

        [ForeignKey("Channel")]
        public string ChannelId { get; set; }
        public virtual Channel Channel { get; set; }
    }
}

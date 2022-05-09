namespace WebApplication3.Models
{
    public class Channel
    {
        public string ChannelId { get; set; }
        public string ChannelName { get; set; }
        public string ImageUrl { get; set; }

        public virtual User User { get; set; }
    }
}

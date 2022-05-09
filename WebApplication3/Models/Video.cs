namespace WebApplication3.Models
{
    public class Video
    {
        public string VideoId { get; set; }
        public string Title { get; set; }
        public string ImageUrl { get; set; }
        public Channel Channel { get; set; }
        public string Views { get; set; }
        public string Likes { get; set; }
    }
}

using Microsoft.EntityFrameworkCore;
using WebApplication3.Models;
namespace WebApplication3.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Youtube> Youtube { get; set; }
        public DbSet<Video> Videos { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<History> History { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


            modelBuilder.Entity<Video>()
            .HasData(
             new Video
             {
                 VideoId = "Y2Oj9gllHno",
                 Title = "I am a Chef | Aakash Gupta | Stand-Up Comedy | Crowd Work",
                 ImageUrl = "https://i.ytimg.com/vi/Y2Oj9gllHno/hqdefault.jpg",
                 UserId = "1",
                 Views = "8,521,590",
                 Likes = "714K"

             },
             new Video
             {
                 VideoId = "dwapUG-XFKs",
                 Title = "Shell profits nearly triple as oil prices surge amid Russia-Ukraine war – BBC News",
                 ImageUrl = "https://i.ytimg.com/vi/dwapUG-XFKs/hqdefault.jpg",
                 UserId = "2",
                 Views = "103,889",
                 Likes = "1K"

             },

             new Video
             {
                 VideoId = "ZQ4E0JJcxz0",
                 Title = "What Happens When the iPhone Peaks ? ",
                 ImageUrl = "https://i.ytimg.com/vi/ZQ4E0JJcxz0/hqdefault.jpg",
                 UserId = "3",
                 Views = "3,274,362",
                 Likes = "133K"

             },
             new Video
             {

                 VideoId = "yoigsHYc77s",
                 Title = "The Apple Studio Display is a Bad Deal",
                 ImageUrl = "https://i.ytimg.com/vi/yoigsHYc77s/hqdefault.jpg",
                 UserId = "3",
                 Views = "3,571,065",
                 Likes = "131K"
             },
             new Video
             {

                 VideoId = "vXIAB_1FEC0",
                 Title = "Galaxy S22 Ultra Review: Separating from the Pack!",
                 ImageUrl = "https://i.ytimg.com/vi/vXIAB_1FEC0/hqdefault.jpg",
                 UserId = "1", 
                 Views = "3,578,675",
                 Likes = "122K"

             },

                new Video
                {
                    VideoId = "bQY07sHbF2w",
                    Title = "Real Madrid to face Liverpool in Champions League final as comeback stuns Man City - BBC News",
                    ImageUrl = "https://i.ytimg.com/vi/bQY07sHbF2w/hqdefault.jpg",
                    UserId = "2",
                    Views = "23,079",
                    Likes = "600"

                },
             new Video
             {
                 VideoId = "VCJZVtKIwrU",
                 Title = "Russia's flagship warship the Moskva has sunk – BBC News",
                 ImageUrl = "https://i.ytimg.com/vi/VCJZVtKIwrU/hqdefault.jpg",
                 UserId = "2",
                 Views = "1,864,946",
                 Likes = "16K"

             }




             );
            modelBuilder.Entity<User>()
             .HasData(
                new User
                {
                    UserId = "1",
                    Email = "aakashgupta@gmail.com",
                    UserName = "Aakash Gupta",
                    ProfileImg = "https://yt3.ggpht.com/ytc/AKedOLSvPEUzOL_qQkQQd17lcsvj3ikeb2iEj92MUBi91A=s68-c-k-c0x00ffffff-no-rj"

                },
                new User
                {
                    UserId = "2",
                    Email = "bbc@gmail.com",
                    UserName = "BBC NEWS",
                    ProfileImg = "https://yt3.ggpht.com/MRywaef1JLriHf-MUivy7-WAoVAL4sB7VHZXgmprXtmpOlN73I4wBhjjWdkZNFyJNiUP6MHm1w=s176-c-k-c0x00ffffff-no-rj"

                },
                new User
                {
                    UserId = "3",
                    Email = "mkbhd@gmail.com",
                    UserName = "Marques Brownlee",
                    ProfileImg = "https://yt3.ggpht.com/lkH37D712tiyphnu0Id0D5MwwQ7IRuwgQLVD05iMXlDWO-kDHut3uI4MgIEAQ9StK0qOST7fiA=s176-c-k-c0x00ffffff-no-rj"

                }
                );

        }

    }
}

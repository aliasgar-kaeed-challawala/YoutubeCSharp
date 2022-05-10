﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApplication3.Data;

namespace WebApplication3.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.24")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebApplication3.Models.History", b =>
                {
                    b.Property<string>("HistoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("VideoId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("HistoryId");

                    b.HasIndex("UserId");

                    b.HasIndex("VideoId");

                    b.ToTable("History");
                });

            modelBuilder.Entity("WebApplication3.Models.User", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProfileImg")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            UserId = "1",
                            Email = "aakashgupta@gmail.com",
                            ProfileImg = "https://yt3.ggpht.com/ytc/AKedOLSvPEUzOL_qQkQQd17lcsvj3ikeb2iEj92MUBi91A=s68-c-k-c0x00ffffff-no-rj",
                            UserName = "Aakash Gupta"
                        },
                        new
                        {
                            UserId = "2",
                            Email = "bbc@gmail.com",
                            ProfileImg = "https://yt3.ggpht.com/MRywaef1JLriHf-MUivy7-WAoVAL4sB7VHZXgmprXtmpOlN73I4wBhjjWdkZNFyJNiUP6MHm1w=s176-c-k-c0x00ffffff-no-rj",
                            UserName = "BBC NEWS"
                        },
                        new
                        {
                            UserId = "3",
                            Email = "mkbhd@gmail.com",
                            ProfileImg = "https://yt3.ggpht.com/lkH37D712tiyphnu0Id0D5MwwQ7IRuwgQLVD05iMXlDWO-kDHut3uI4MgIEAQ9StK0qOST7fiA=s176-c-k-c0x00ffffff-no-rj",
                            UserName = "Marques Brownlee"
                        });
                });

            modelBuilder.Entity("WebApplication3.Models.Video", b =>
                {
                    b.Property<string>("VideoId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Likes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Views")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("VideoId");

                    b.HasIndex("UserId");

                    b.ToTable("Videos");

                    b.HasData(
                        new
                        {
                            VideoId = "Y2Oj9gllHno",
                            ImageUrl = "https://i.ytimg.com/vi/Y2Oj9gllHno/hqdefault.jpg",
                            Likes = "714K",
                            Title = "I am a Chef | Aakash Gupta | Stand-Up Comedy | Crowd Work",
                            UserId = "1",
                            Views = "8,521,590"
                        },
                        new
                        {
                            VideoId = "dwapUG-XFKs",
                            ImageUrl = "https://i.ytimg.com/vi/dwapUG-XFKs/hqdefault.jpg",
                            Likes = "1K",
                            Title = "Shell profits nearly triple as oil prices surge amid Russia-Ukraine war – BBC News",
                            UserId = "2",
                            Views = "103,889"
                        },
                        new
                        {
                            VideoId = "ZQ4E0JJcxz0",
                            ImageUrl = "https://i.ytimg.com/vi/ZQ4E0JJcxz0/hqdefault.jpg",
                            Likes = "133K",
                            Title = "What Happens When the iPhone Peaks ? ",
                            UserId = "3",
                            Views = "3,274,362"
                        },
                        new
                        {
                            VideoId = "yoigsHYc77s",
                            ImageUrl = "https://i.ytimg.com/vi/yoigsHYc77s/hqdefault.jpg",
                            Likes = "131K",
                            Title = "The Apple Studio Display is a Bad Deal",
                            UserId = "3",
                            Views = "3,571,065"
                        },
                        new
                        {
                            VideoId = "vXIAB_1FEC0",
                            ImageUrl = "https://i.ytimg.com/vi/vXIAB_1FEC0/hqdefault.jpg",
                            Likes = "122K",
                            Title = "Galaxy S22 Ultra Review: Separating from the Pack!",
                            UserId = "1",
                            Views = "3,578,675"
                        },
                        new
                        {
                            VideoId = "bQY07sHbF2w",
                            ImageUrl = "https://i.ytimg.com/vi/bQY07sHbF2w/hqdefault.jpg",
                            Likes = "600",
                            Title = "Real Madrid to face Liverpool in Champions League final as comeback stuns Man City - BBC News",
                            UserId = "2",
                            Views = "23,079"
                        },
                        new
                        {
                            VideoId = "VCJZVtKIwrU",
                            ImageUrl = "https://i.ytimg.com/vi/VCJZVtKIwrU/hqdefault.jpg",
                            Likes = "16K",
                            Title = "Russia's flagship warship the Moskva has sunk – BBC News",
                            UserId = "2",
                            Views = "1,864,946"
                        });
                });

            modelBuilder.Entity("WebApplication3.Models.Youtube", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ChannelTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UploadedAt")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VideoId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Views")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Youtube");
                });

            modelBuilder.Entity("WebApplication3.Models.History", b =>
                {
                    b.HasOne("WebApplication3.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.HasOne("WebApplication3.Models.Video", "Video")
                        .WithMany()
                        .HasForeignKey("VideoId");
                });

            modelBuilder.Entity("WebApplication3.Models.Video", b =>
                {
                    b.HasOne("WebApplication3.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });
#pragma warning restore 612, 618
        }
    }
}

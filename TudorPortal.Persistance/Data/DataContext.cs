using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tudor_Vladimirescu_students__portal.Persistance.Data.Mappings;
using Tudor_Vladimirescu_students__portal.Entities;

namespace Tudor_Vladimirescu_students__portal.Data
{
    public class TudorPortalDbContext : DbContext
    { 
        public DbSet<User> User { get; set; }
        public DbSet<Topics> Topics { get; set; }
        public DbSet<Event> Event { get; set; }
        public DbSet<Comment> Comment { get; set; }
        public DbSet<EventLike> EventLike { get; set; }
        public DbSet<TopicLike> TopicLike { get; set; }

        public TudorPortalDbContext(DbContextOptions<TudorPortalDbContext>options)
            : base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = @"Server=(local)\SQLEXPRESS;Database=TudorPortal;Trusted_Connection=True;";
            //optionsBuilder.UseLazyLoadingProxies();
            optionsBuilder.UseSqlServer(@connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            UserMapping.Map(modelBuilder);
            TopicsMapping.Map(modelBuilder);
            EventMapping.Map(modelBuilder);
            CommentMapping.Map(modelBuilder);
            TopicLikeMapping.Map(modelBuilder);
            EventLikeMapping.Map(modelBuilder);
            SeedDatabase(modelBuilder);
        }

        public static void SeedDatabase(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(new List<User>()
            {
                new User()
                {
                    Id = 1,
                    FirstName = "Ioana",
                    LastName = "Popescu",
                    Email = "ioanapopescu@gmail.com",
                    Avatar = "fatamea1.png",
                    Hashedpassword = "12345",
                    IsAdministrator = false
                }

                //new User()
                //{
                //    Id = 2,
                //    FirstName = "Stefania",
                //    LastName = "Alucai",
                //    Email = "stefaniaalucai@gmail.com",
                //    Avatar = "fatamea2.png",
                //    Hashedpassword = "123456",
                //    IsAdministrator = false
                //},

                //new User()
                //{
                //    Id = 3,
                //    FirstName = "Stefana",
                //    LastName = "Manta",
                //    Email = "stefanamanta@gmail.com",
                //    Avatar = "fatamea3.png",
                //    Hashedpassword = "123",
                //    IsAdministrator = false
                //}
            });

            modelBuilder.Entity<Event>().HasData(new List<Event>()
            {
                new Event()
                {
                    Id = 1,
                    Title = "Title1",
                    Content = "Lorem Ipsum1",
                    Eventcreated = new DateTime(2022,05,08,9,20,0),
                    Picture = "amfiteatru1.png",
                    UserId = 1

                }

                //new Event()
                //{
                //    Id = 2,
                //    Title = "Title2",
                //    Content = "Lorem Ipsum2",
                //    Eventcreated = new DateTime(2022,05,09,9,15,0),
                //    Picture = "amfiteatru2.png",
                //    UserId = 2
                //},

                //new Event()
                //{
                //    Id = 3,
                //    Title = "Title3",
                //    Content = "Lorem Ipsum3",
                //    Eventcreated = new DateTime(2022,05,10,8,15,0),
                //    Picture = "amfiteatru3.png",
                //    UserId = 3
                //}
            });

            modelBuilder.Entity<Topics>().HasData(new List<Topics>()
            {
                new Topics()
                {
                    Id = 1,
                    Title = "Topic",
                    Content = "Topicuri",
                    Topiccreated = new DateTime(2022,06,09,9,15,0),
                    Status = 1,
                    Picture ="topic.png",
                    UserId = 1
                }
            });

            modelBuilder.Entity<Comment>().HasData(new List<Comment>()
            {
                new Comment()
                {
                    Id = 1,
                    Commentitself= "Comment",
                    UserId = 1,
                    TopicsId = 1 
                }
            });

            modelBuilder.Entity<TopicLike>().HasData(new List<TopicLike>()
            {
                new TopicLike()
                {
                    Id = 1,
                    NumberOfLikes = 1,
                    UserId = 1,
                    TopicId = 1
                }
            });

            modelBuilder.Entity<EventLike>().HasData(new List<EventLike>()
            {
                new EventLike()
                {
                    Id =1,
                    NumberOfLikes = 1,
                    EventId = 1,
                    UserId = 1
                }
            });
        }

    }
}

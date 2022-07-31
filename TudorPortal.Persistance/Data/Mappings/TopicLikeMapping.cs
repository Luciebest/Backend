using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tudor_Vladimirescu_students__portal.Entities;

namespace Tudor_Vladimirescu_students__portal.Persistance.Data.Mappings
{
    internal abstract class TopicLikeMapping
    {
        internal static void Map(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TopicLike>()
                .Property(s => s.Id)
                .HasColumnName("TopicLikeId")
                .IsRequired();

            modelBuilder.Entity<TopicLike>()
               .Property(s => s.NumberOfLikes)
               .IsRequired();
            
            modelBuilder.Entity<TopicLike>()
                .HasOne(tl => tl.User)
                .WithMany(tl => tl.TopicLikes)
                .OnDelete(DeleteBehavior.Restrict)
                .HasForeignKey(tl => tl.UserId);

            modelBuilder.Entity<TopicLike>()
                .HasOne(tl => tl.Topic)
                .WithMany(tl => tl.TopicLikes)
                .OnDelete(DeleteBehavior.Restrict)
                .HasForeignKey(tl => tl.TopicId);
        }
    }
}

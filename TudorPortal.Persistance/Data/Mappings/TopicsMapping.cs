using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tudor_Vladimirescu_students__portal.Entities;

namespace Tudor_Vladimirescu_students__portal.Persistance.Data.Mappings
{
    internal abstract class TopicsMapping
    {
        internal static void Map(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Topics>()
                .Property(s => s.Id)
                .HasColumnName("TopicId")
                .IsRequired();

            modelBuilder.Entity<Topics>()
                .Property(s => s.Title)
                .HasColumnName("Title")
                .HasMaxLength(50)
                .IsRequired();

            modelBuilder.Entity<Topics>()
                .Property(s => s.Content)
                .HasColumnName("Content")
                .HasMaxLength(200)
                .IsRequired();

            modelBuilder.Entity<Topics>()
                .Property(s => s.Topiccreated)
                .HasColumnName("TopicCreated")
                .IsRequired();

            modelBuilder.Entity<Topics>()
                .Property(s => s.Status)
                .HasColumnName("Status")
                .HasMaxLength(3)
                .IsRequired();

            modelBuilder.Entity<Topics>()
                .Property(s => s.Picture)
                .HasColumnName("Picture")
                .IsRequired();

            modelBuilder.Entity<Topics>()
                .HasOne(tl => tl.User)
                .WithMany(tl => tl.Topics)
                .OnDelete(DeleteBehavior.Restrict)
                .HasForeignKey(tl => tl.UserId);
        }

    }
}

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tudor_Vladimirescu_students__portal.Entities;

namespace Tudor_Vladimirescu_students__portal.Persistance.Data.Mappings
{
    internal abstract class CommentMapping
    {
        internal static void Map(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Comment>()
                .Property(s => s.Id)
                .HasColumnName("CommentId")
                .IsRequired();

            modelBuilder.Entity<Comment>()
               .Property(s => s.Commentitself)
               .HasColumnName("Commentitself")
               .HasMaxLength(200)
               .IsRequired();

            modelBuilder.Entity<Comment>()
                .HasOne(tl => tl.User)
                .WithMany(tl => tl.Comment)
                .OnDelete(DeleteBehavior.Restrict)
                .HasForeignKey(tl => tl.UserId);

            modelBuilder.Entity<Comment>()
                .HasOne(tl => tl.Topics)
                .WithMany(tl => tl.Comment)
                .OnDelete(DeleteBehavior.Restrict)
                .HasForeignKey(tl => tl.TopicsId);
        }
    }
}

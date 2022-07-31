using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tudor_Vladimirescu_students__portal.Entities;

namespace Tudor_Vladimirescu_students__portal.Persistance.Data.Mappings
{
    internal abstract class EventMapping
    {
        internal static void Map(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Event>()
                .Property(s => s.Id)
                .HasColumnName("EventId")
                .IsRequired();

            modelBuilder.Entity<Event>()
                .Property(s => s.Title)
                .HasColumnName("Title")
                .HasMaxLength(50)
                .IsRequired();

            modelBuilder.Entity<Event>()
                .Property(s => s.Content)
                .HasColumnName("Content")
                .HasMaxLength(20000)
                .IsRequired();

            modelBuilder.Entity<Event>()
                .Property(s => s.Eventcreated)
                .IsRequired();

            modelBuilder.Entity<Event>()
                .HasOne(tl => tl.User)
                .WithMany(tl => tl.Event)
                .OnDelete(DeleteBehavior.Restrict)
                .HasForeignKey(tl => tl.UserId);
        }
    }
}

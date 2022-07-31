using Microsoft.EntityFrameworkCore;
using Tudor_Vladimirescu_students__portal.Entities;

namespace Tudor_Vladimirescu_students__portal.Persistance.Data.Mappings
{
    internal abstract class EventLikeMapping
    {
        internal static void Map(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EventLike>()
                .Property(s => s.Id)
                .HasColumnName("EventLikeId")
                .IsRequired();

            modelBuilder.Entity<EventLike>()
               .Property(s => s.NumberOfLikes)
               .IsRequired();

            modelBuilder.Entity<EventLike>()
                .HasOne(tl => tl.Event)
                .WithMany(tl => tl.EventLikes)
                .OnDelete(DeleteBehavior.Restrict)
                .HasForeignKey(tl => tl.EventId);

            modelBuilder.Entity<EventLike>()
                .HasOne(tl => tl.User)
                .WithMany(tl => tl.EventLikes)
                .OnDelete(DeleteBehavior.Restrict)
                .HasForeignKey(tl => tl.UserId);

        }
    }
}

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tudor_Vladimirescu_students__portal.Entities;

namespace Tudor_Vladimirescu_students__portal.Persistance.Data.Mappings
{
    internal abstract class UserMapping
    { 
        internal static void Map(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .Property(s => s.Id)
                .HasColumnName("UserId")
                .IsRequired();

            modelBuilder.Entity<User>()
                .Property(s => s.FirstName)
                .HasColumnName("FirstName")
                .HasMaxLength(20)
                .IsRequired();

            modelBuilder.Entity<User>()
                .Property(s => s.LastName)
                .HasColumnName("LastName")
                .HasMaxLength(20)
                .IsRequired();

            modelBuilder.Entity<User>()
                .Property(s => s.Email)
                .HasColumnName("Email")
                .HasMaxLength(50)
                .IsRequired();

            modelBuilder.Entity<User>()
                .Property(s => s.Avatar)
                .HasColumnName("Avatar")
                .HasMaxLength(50)
                .IsRequired();

            modelBuilder.Entity<User>()
                .Property(s => s.Hashedpassword)
                .HasColumnName("Hashedpassword")
                .HasMaxLength(20)
                .IsRequired();
        }
    }
}

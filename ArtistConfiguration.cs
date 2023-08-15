using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace HW6_module4
{
    internal class ArtistConfiguration : IEntityTypeConfiguration<Artist>
    {
        public void Configure(EntityTypeBuilder<Artist> builder)
        {
            builder.Property(t => t.Id).HasColumnName("Id").IsRequired();
            builder.Property(f => f.Name).HasColumnName("Name").IsRequired();
            builder.Property(f => f.DeteofBirth).HasColumnName("DeteofBirth").IsRequired();
            builder.Property(e => e.Email).HasColumnName("Email");
            builder.Property(e => e.InstagramUrl).HasColumnName("InstagramUrl");
            builder.HasData(new List<Artist>()
            {
               new Artist() { Id = 1, Name = "Ivan", DeteofBirth = new DateTime(1996, 02, 15), Email = "ivavivanov@gmail.com", InstagramUrl = "vaviva1122" },
               new Artist() { Id = 2, Name = "Petr", DeteofBirth = new DateTime(1997, 02, 25), Email = "Petrvanov@gmail.com", InstagramUrl = "Petr1122" },
               new Artist() { Id = 3, Name = "Artem", DeteofBirth = new DateTime(1976, 02, 15), Email = "Artem1212@gmail.com", InstagramUrl = "Artem1212" },
               new Artist() { Id = 4, Name = "Andrey", DeteofBirth = new DateTime(1985, 12, 05), Email = "Andrey1995@gmail.com", InstagramUrl = "Andrey1995" },
               new Artist() { Id = 5, Name = "Anna", DeteofBirth = new DateTime(1999, 08, 11), Email = "Anna1999@gmail.com", InstagramUrl = "Anna1412" }
            });
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace HW6_module4
{
    internal class GenreConfiguration : IEntityTypeConfiguration<Genre>
    {
        public void Configure(EntityTypeBuilder<Genre> builder)
        {
            builder.Property(t => t.Id).HasColumnName("Id").IsRequired();
            builder.Property(f => f.Title).HasColumnName("Name").IsRequired();
            builder.HasMany(s => s.Songs).WithOne(g => g.Genre).HasForeignKey(p => p.GenreId).OnDelete(DeleteBehavior.Cascade);
            builder.HasData(new List<Genre>()
            {
               new Genre() { Id = 1, Title = "Pop" },
               new Genre() { Id = 2, Title = "Rock" },
               new Genre() { Id = 3, Title = "Djaz" },
               new Genre() { Id = 4, Title = "Classic" },
               new Genre() { Id = 5, Title = "Rap" }
            });
        }
    }
}

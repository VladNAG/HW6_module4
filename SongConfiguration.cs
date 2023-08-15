using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace HW6_module4
{
    internal class SongConfiguration : IEntityTypeConfiguration<Song>
    {
        public void Configure(EntityTypeBuilder<Song> builder)
        {
            builder.Property(t => t.Id).HasColumnName("Id").IsRequired();
            builder.Property(f => f.Title).HasColumnName("Title").IsRequired();
            builder.Property(f => f.Duration).HasColumnName("Duration").IsRequired();
            builder.Property(e => e.ReleasedDate).HasColumnName("ReleasedDate").IsRequired();
            builder.HasData(new List<Song>()
              {
                  new Song() { Id = 1, Title = "Lastivki", ReleasedDate = new DateTime(2022, 02, 15), Duration = 4.5, GenreId = 1 },
                  new Song() { Id = 2, Title = "Klever", ReleasedDate = new DateTime(2023, 01, 25), Duration = 3.5, GenreId = 5 },
                  new Song() { Id = 3, Title = "Tyt", ReleasedDate = new DateTime(2014, 02, 15), Duration = 4.3, GenreId = 5 },
                  new Song() { Id = 4, Title = "Kykyshka", ReleasedDate = new DateTime(1994, 11, 05), Duration = 4.5, GenreId = 2 },
                  new Song() { Id = 5, Title = "Prognoz", ReleasedDate = new DateTime(2010, 02, 15), Duration = 3.8, GenreId = 3 }
              });
            builder.HasMany(s => s.Artists)
                .WithMany(d => d.Songs)
                .UsingEntity<Dictionary<string, object>>(
                "ArtistSong",
                l => l
                .HasOne<Artist>()
                .WithMany()
                .HasForeignKey("ArtistId"),
                l => l
                .HasOne<Song>()
                .WithMany()
                .HasForeignKey("SongId"),
                je =>
                {
                    je.HasKey("ArtistId", "SongId");
                    je.HasData(
                        new { ArtistId = 1, SongId = 2 },
                        new { ArtistId = 1, SongId = 4 },
                        new { ArtistId = 2, SongId = 5 },
                        new { ArtistId = 3, SongId = 4 },
                        new { ArtistId = 4, SongId = 2 },
                        new { ArtistId = 5, SongId = 1 });
                });
        }
    }
}
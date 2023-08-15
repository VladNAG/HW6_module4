using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace HW6_module4
{
    public static class Starter
    {
        public static void Start()
        {
            using (var db = new AppContext())
            {
                Console.WriteLine("Task 1 ");
                var songs = from song in db.Songs
                            select new { g = song.Genre.Title, s = song.Title, a = song.Artists.ToList() };
                foreach (var song in songs)
                {
                    if (song.g != default && song.a.Count > 0)
                    {
                        Console.WriteLine($"Song-{song.s}, Ganre-{song.g}");
                        foreach (var song2 in song.a)
                        {
                            Console.WriteLine($"artist -{song2.Name} ");
                        }
                    }
                }
            }

            using (var db = new AppContext())
            {
                Console.WriteLine();
                Console.WriteLine("Task 2 ");
                var countsong = from g in db.Genre
                                select new { countgenre = g.Songs.Count, name = g.Title };
                foreach (var s in countsong)
                {
                    Console.WriteLine($"{s.countgenre}-{s.name}");
                }
            }

            using (var db = new AppContext())
            {
                Console.WriteLine();
                Console.WriteLine("Task 2 ");
                var countsong = db.Genre.Select(g => new { countgenre = g.Songs.Count, name = g.Title });
                foreach (var s in countsong)
                {
                    Console.WriteLine($"{s.countgenre}-{s.name}");
                }
            }

            using (var db = new AppContext())
            {
                Console.WriteLine();
                Console.WriteLine("Task 3 ");
                var songs = from song in db.Songs
                            select new { n = song.Title, dr = song.ReleasedDate };
                var a = db.Artists.Min(p => p.DeteofBirth);
                foreach (var song in songs)
                {
                    if (song.dr > a)
                    {
                        Console.WriteLine($"{song.dr}-{song.n}");
                    }
                }
            }
        }
    }
}

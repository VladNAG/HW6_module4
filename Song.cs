using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW6_module4
{
    public class Song
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public double Duration { get; set; }
        public DateTime ReleasedDate { get; set; }
        public int GenreId { get; set; }
        public Genre Genre { get; set; }
        public List<Artist> Artists { get; set; } = new List<Artist>();
    }
}

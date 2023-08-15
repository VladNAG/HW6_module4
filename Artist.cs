using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW6_module4
{
    public class Artist
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DeteofBirth { get; set; }
        public string? Phone { get; set; }
        public string? Email { get; set; }
        public string? InstagramUrl { get; set; }
        public List<Song> Songs { get; set; } = new List<Song>();
    }
}

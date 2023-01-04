using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst
{
    public class Video
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime ReleaseDate { get; set; }
        public Genre Genre { get; set; }
        public Classification Classification { get; set; }
    }

    public class Genre
    {
        public byte Id { get; set; }
        public string Name { get; set; }
       // public ICollection<Video> Videos { get; set; }
    }
    public class CodeFirstContext : DbContext
    {
        public DbSet<Video> Videos { get; set; }
        public DbSet<Genre> Genres { get; set; }
    }
    public enum Classification
    {
        Gold = 1,
        Silver = 2,
        Platinum = 3
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}

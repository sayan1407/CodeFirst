using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using CodeFirst.EntityConfiguration;

namespace CodeFirst
{
    public class CodeFirstContext : DbContext
    {
        public CodeFirstContext()
        {
            this.Configuration.LazyLoadingEnabled = false;
        }
        public DbSet<Video> Videos { get; set; }
        public DbSet<Genre> Genres { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new VideoConfiguration());
            modelBuilder.Configurations.Add(new GenreConfiguration());
            base.OnModelCreating(modelBuilder);
        }
    }
}

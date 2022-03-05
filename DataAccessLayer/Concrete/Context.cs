using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-BIVS41I;database=CinensSinemalariCore; Integrated Security=True");
        }


        public DbSet<About> Abouts { get; set; }
        public DbSet<Contact> ContactUs { get; set; }
        public DbSet<GeneralAudience> GeneralAudiences { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<MovieTheater> MovieTheaters { get; set; }
        public DbSet<NewsLetter> NewsLetters { get; set; }
        public DbSet<Branch> Branches { get; set; }
    }
}

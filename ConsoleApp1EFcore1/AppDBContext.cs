using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1EFcore1
{
    public class AppDBContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.; Database=ConsoleApp1EFcore1;Trusted_Connection=True;TrustServerCertificate=True");
        }
        public DbSet<Modals.Author> Authors { get; set; }
        public DbSet<Modals.Books> Books { get; set; }
        public DbSet<Modals.Category> Categories { get; set; }
    }
}

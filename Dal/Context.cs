using JwtOrnekProje.Models;
using Microsoft.EntityFrameworkCore;

namespace JwtOrnekProje.Dal
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-U4DC5DI; initial catalog = JwtProjectApi; Integrated Security = True");
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}

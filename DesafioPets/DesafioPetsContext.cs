  using DesafioPets.Models;
using Microsoft.EntityFrameworkCore;

namespace DesafioPets
{
    public class DesafioPetsContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=VHMPC\\SQLSERVER; Initial Catalog=DesafioPetBd; Integrated Security=True");
        }

        public DbSet<Pessoa> Pessoas { get; set; }
        public DbSet<Pet> Pets { get; set; }
    }
}

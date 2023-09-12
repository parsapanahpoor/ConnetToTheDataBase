using ConnetToTheDataBase.Models;
using Microsoft.EntityFrameworkCore;

namespace ConnetToTheDataBase
{
    public class TestDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-JCN2C1I\\MSSQLSERVER2019;Initial Catalog=TestDbConnetion;Integrated Security=True;MultipleActiveResultSets=true;TrustServerCertificate=True");
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<User> Users { get; set; }
    }
}

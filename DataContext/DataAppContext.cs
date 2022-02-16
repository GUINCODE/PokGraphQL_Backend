using Microsoft.EntityFrameworkCore;

namespace Ge2Co.DataAppContext {
    public class DataAppContext : DbContext {
   
        public DataAppContext(DbContextOptions<DataAppContext> options) : base (options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Initial Catalog=DBName;Integrated Security=True");
        }

        // public DbSet<EntityName> EntityNames { get; set; }
    }
}
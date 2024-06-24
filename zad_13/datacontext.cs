

using Microsoft.EntityFrameworkCore;

namespace zad_13
{
    public class datacontext : DbContext
    {
        public DbSet<model> models { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source = qwefqwf.db");
        }



    }
}

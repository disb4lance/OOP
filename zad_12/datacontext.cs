using Microsoft.EntityFrameworkCore;

namespace zad_12
{
    public class datacontext : DbContext
    {
        public  DbSet<model> models { get; set; }

        //public datacontext() {
        //    Database.Migrate();
        //    //Database.EnsureDeleted();
        //    //Database.EnsureCreated();
        //}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseSqlServer("Server = (localdb)\\MSSQLLocalDB; DataBase = qwe; Trusted_Connection = True; TrustServerCertificate = True");
        }
    }
}

using System.Data.Entity;
namespace Vidly.Models
{
    public class MyDBContext : DbContext
    {
        public MyDBContext()
        {

        }
        //public DbSet<Costumers> Costumers { get; set; } // My domain models
        //public DbSet<Movie> Movies { get; set; }// My domain models

        public DbSet<Videos> Videos { get; set; }
        public DbSet<Kategorien> Kategorien { get; set; }
        public DbSet<Kuenstler> Kuenstler { get; set; }



    }
}
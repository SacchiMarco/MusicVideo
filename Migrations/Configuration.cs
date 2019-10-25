namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.IO;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Vidly.Models.MyDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Vidly.Models.MyDBContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            var baseDir = AppDomain.CurrentDomain.BaseDirectory.Replace("\\bin", string.Empty) + "\\Migrations";

            //context.Database.ExecuteSqlCommand(File.ReadAllText(baseDir + "\\kategorien.sql"));
            //context.Database.ExecuteSqlCommand(File.ReadAllText(baseDir + "\\kuenstler.sql"));
            //context.Database.ExecuteSqlCommand(File.ReadAllText(baseDir + "\\videos.sql"));
            
        }
    }
}

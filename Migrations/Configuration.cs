namespace FunTour.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<FunTour.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "FunTour.Models.ApplicationDbContext";
        }

        protected override void Seed(FunTour.Models.ApplicationDbContext context)
        {
         
        }
    }
}

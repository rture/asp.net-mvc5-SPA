namespace SPA_Cloud_Sample.Migrations
{
    using SPA_Cloud_Sample.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<SPA_Cloud_Sample.Models.SPA_Cloud_SampleContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(SPA_Cloud_Sample.Models.SPA_Cloud_SampleContext context)
        {
           
            context.Contacts.AddOrUpdate(p => p.Name,
    
        new Contact
        {
            Name = "Riza Ture",
            Address = "Harvard Road",
            City = "Boston",
            State = "MA",
            Zip = "02145",
            Email = "rture@example.com",
            Twitter = "rture_example"
        }
        );
        }
    }
}

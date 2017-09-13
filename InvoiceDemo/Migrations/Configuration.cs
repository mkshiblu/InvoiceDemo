namespace InvoiceDemo.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using InvoiceDemo.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<InvoiceDemo.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
            ContextKey = "InvoiceDemo.Models.ApplicationDbContext";
        }

        protected override void Seed(InvoiceDemo.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            /// TUTORIAL LINK: https://www.asp.net/mvc/overview/getting-started/getting-started-with-ef-using-mvc/migrations-and-deployment-with-the-entity-framework-in-an-asp-net-mvc-application

            // Create some products
            var products = new List<Product>
            {
                new Product { Name = "Shampoo", Description = "Good for your hair", UnitPrice = 50.0 },
                new Product { Name = "Blender", Description = "Mix your food.", UnitPrice = 760.0},
                new Product { Name = "Apple", Description = "Fresh & Organic fruit", UnitPrice = 180}
            };

            // Add / update some products to the Products List with name as identifier
            products.ForEach(p => context.Products.AddOrUpdate(product => product.Name, p));
            context.SaveChanges();

            // Create some clients
            var clients = new List<Client>
            {
                new Client { Name = "John", Address = "Mohakhali" },
                new Client { Name = "Stacy", Address = "Canada" },
                new Client { Name = "Adam", Address = "New York" },
                new Client { Name = "Billy", Address = "Texas" }
            };

            // Add / update some clients to the Clients List with name as identifier
            clients.ForEach(c => context.Clients.AddOrUpdate(client => client.Name, c));
            context.SaveChanges();

            // TODO adding Some Invoice & Invoie item
        }
    }
}

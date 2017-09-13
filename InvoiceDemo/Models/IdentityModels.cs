using System.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace InvoiceDemo.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection")
        {
            Database.SetInitializer<ApplicationDbContext>(new CreateDatabaseIfNotExists<ApplicationDbContext>());
        }

        public System.Data.Entity.DbSet<InvoiceDemo.Models.Client> Clients { get; set; }
        public System.Data.Entity.DbSet<InvoiceDemo.Models.Invoice> Invoices { get; set; }
        public System.Data.Entity.DbSet<InvoiceDemo.Models.InvoiceItem> InvoiceItems { get; set; }

        public System.Data.Entity.DbSet<InvoiceDemo.Models.Product> Products { get; set; }
    }
}
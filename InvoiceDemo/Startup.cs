using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(InvoiceDemo.Startup))]
namespace InvoiceDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

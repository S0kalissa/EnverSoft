using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SupplierDatabase.Startup))]
namespace SupplierDatabase
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PhoneBook.WebApp.Startup))]
namespace PhoneBook.WebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

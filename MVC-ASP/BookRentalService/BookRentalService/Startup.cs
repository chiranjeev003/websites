using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BookRentalService.Startup))]
namespace BookRentalService
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

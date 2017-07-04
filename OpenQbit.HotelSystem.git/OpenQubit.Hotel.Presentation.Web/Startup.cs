using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OpenQubit.Hotel.Presentation.Web.Startup))]
namespace OpenQubit.Hotel.Presentation.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LibraryMengament.Startup))]
namespace LibraryMengament
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

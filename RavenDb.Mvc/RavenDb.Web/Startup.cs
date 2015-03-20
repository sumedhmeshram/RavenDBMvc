using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RavenDb.Web.Startup))]
namespace RavenDb.Web
{
    public partial class Startup
    {
        //public void Configuration(IAppBuilder app)
        //{
        //    ConfigureAuth(app);
        //}
    }
}

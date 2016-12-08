using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestWithRavenDb.Startup))]
namespace TestWithRavenDb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

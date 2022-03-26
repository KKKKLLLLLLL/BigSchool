using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BigSchoolLDK.Startup))]
namespace BigSchoolLDK
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

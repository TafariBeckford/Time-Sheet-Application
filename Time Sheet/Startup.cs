using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Time_Sheet.Startup))]
namespace Time_Sheet
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

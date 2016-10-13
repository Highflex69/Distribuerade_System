using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Labb2_Distribuerad_System.Startup))]
namespace Labb2_Distribuerad_System
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ZCSS_SDvpt_Orientation_Test.Startup))]
namespace ZCSS_SDvpt_Orientation_Test
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
        //Application Guide
    }
}

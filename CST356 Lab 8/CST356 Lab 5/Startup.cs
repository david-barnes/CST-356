using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CST356_Lab_5.Startup))]
namespace CST356_Lab_5
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

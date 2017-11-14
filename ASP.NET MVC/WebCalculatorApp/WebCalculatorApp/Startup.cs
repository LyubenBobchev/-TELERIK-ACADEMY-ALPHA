using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebCalculatorApp.Startup))]
namespace WebCalculatorApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

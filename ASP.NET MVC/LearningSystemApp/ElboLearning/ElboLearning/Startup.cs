using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ElboLearning.Startup))]
namespace ElboLearning
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

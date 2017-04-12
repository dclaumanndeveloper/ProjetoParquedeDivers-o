using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PqDiversoes.Startup))]
namespace PqDiversoes
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

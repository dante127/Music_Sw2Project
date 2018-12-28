using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MusicMvc.Startup))]
namespace MusicMvc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

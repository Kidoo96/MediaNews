using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MediaNews.Startup))]
namespace MediaNews
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

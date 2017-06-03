using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MediaNews.Index.Startup))]
namespace MediaNews.Index
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

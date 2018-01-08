using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MultiSelectListDemo.Startup))]
namespace MultiSelectListDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

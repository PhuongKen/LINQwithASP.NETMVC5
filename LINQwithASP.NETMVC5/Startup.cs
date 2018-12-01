using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LINQwithASP.NETMVC5.Startup))]
namespace LINQwithASP.NETMVC5
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

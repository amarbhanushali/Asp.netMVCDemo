using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CashBack.Startup))]
namespace CashBack
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

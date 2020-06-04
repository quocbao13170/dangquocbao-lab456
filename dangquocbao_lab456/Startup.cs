using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(dangquocbao_lab456.Startup))]
namespace dangquocbao_lab456
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CodeFirstMvcProject_Arefin.Startup))]
namespace CodeFirstMvcProject_Arefin
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

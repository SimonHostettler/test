using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestSolution.Startup))]
namespace TestSolution
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

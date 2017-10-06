using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(ElderFitnessService.Startup))]

namespace ElderFitnessService
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureMobileApp(app);
        }
    }
}
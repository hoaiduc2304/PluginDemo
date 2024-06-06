using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Plugin.Abstraction.Plugins;
using ProjectModule.Services;


namespace ProjectModule
{
    public class ProjectModulePlugin : IPlugin
    {
        public string Id => "2a0b3567-5a4e-4d75-90a7-7bb0f426354d";
        public string Name => "Project Module";

        public void RegisterDI(IServiceCollection services, IConfiguration config)
        {
            services.AddScoped<ITaskServices, TaskServices>();
        }
    }
}

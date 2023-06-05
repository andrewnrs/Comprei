using Comprei.View;
using Comprei.Database.Context;
using Microsoft.Extensions.DependencyInjection;
using Comprei.Database.Repositories;
using Comprei.Controller;

namespace Comprei
{
    internal static class Program
    {
        [STAThread]
        public static void Main()
        {
            ApplicationConfiguration.Initialize();

            var serviceCollection = new ServiceCollection();
            ConfigureServices(serviceCollection);

            var serviceProvider = serviceCollection.BuildServiceProvider();

            var mainForm = serviceProvider.GetRequiredService<LoginForm>();
            Application.Run(mainForm);
        }

        private static void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<CompreiContext>();
            
            services.AddSingleton<CustomerController>();
            services.AddSingleton<CustomerRepository>();

            services.AddScoped<LoginForm>();
            services.AddScoped<HomePageForm>();
            services.AddScoped<RegistrationForm>();
        }
    }
}
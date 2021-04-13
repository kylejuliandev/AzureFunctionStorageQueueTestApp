using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using System;
using System.Reflection;
using TestAzureQueueInput;

[assembly: FunctionsStartup(typeof(Startup))]

namespace TestAzureQueueInput
{
    public class Startup : FunctionsStartup
    {
        public override void Configure(IFunctionsHostBuilder builder)
        {
        }

        public override void ConfigureAppConfiguration(IFunctionsConfigurationBuilder builder)
        {
            builder.ConfigurationBuilder
               .SetBasePath(Environment.CurrentDirectory)
               .AddUserSecrets(Assembly.GetExecutingAssembly(), false)
               .AddEnvironmentVariables()
               .Build();
        }
    }
}
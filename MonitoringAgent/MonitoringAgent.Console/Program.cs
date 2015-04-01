using System;
using System.Linq;
using Microsoft.Practices.Unity;
using MonitoringAgent.Services.Common.Contracts;
using MonitoringAgent.WcfServices.Interfaces.Services;

namespace MonitoringAgent
{
    class Program
    {
        static void Main(string[] args)
        {
            var config = new Configuration.Configuration();
            config.Initialize();

            var checkingModules = config.Container.ResolveAll<ICheckingModule>().ToArray();
            foreach (var checkingModule in checkingModules)
            {
                checkingModule.Initialize();
                checkingModule.StartAllChecks();
            }

            var configService = config.Container.Resolve<IConfigurationService>();
            configService.Initialize();
            configService.NeedReconfigure += (sender, eventArgs) =>
            {
                foreach (var checkingModule in checkingModules)
                {
                    checkingModule.Reinitialize();
                    checkingModule.StartAllChecks();
                }
            };

            Console.ReadLine();
        }

        private static void ConfigServiceOnNeedReconfigure(object sender, EventArgs eventArgs)
        {
            
        }
    }
}

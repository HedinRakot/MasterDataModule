using System;
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

            var checkingServices = config.Container.ResolveAll<ICheckingService>();
            foreach (var checkingService in checkingServices)
            {
                checkingService.StartChecking();
            }

            Console.ReadLine();
        }
    }
}

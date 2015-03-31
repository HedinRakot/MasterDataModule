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

            var checkingModules = config.Container.ResolveAll<ICheckingModule>();
            foreach (var checkingModule in checkingModules)
            {
                checkingModule.Initialize();
            }

            Console.ReadLine();
        }
    }
}

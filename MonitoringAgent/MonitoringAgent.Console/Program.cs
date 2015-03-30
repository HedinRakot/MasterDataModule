using System;
using Microsoft.Practices.Unity;
using MonitoringAgent.WcfServices.Interfaces.Services;

namespace MonitoringAgent
{
    class Program
    {
        static void Main(string[] args)
        {
            var application = new Application();
            application.Initialize();
            var wcfManager = application.Container.Resolve<IWcfServicePingManager>();
            wcfManager.StartChecking();
            Console.ReadLine();
        }
    }
}

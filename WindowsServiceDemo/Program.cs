using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WindowsServiceDemo
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main()
        {
            var service = new Service1();
#if DEBUG
            service.DebugMode();
            Thread.Sleep(Timeout.Infinite);
#else
           
                log4net.Config.XmlConfigurator.Configure();
                ServiceBase[] ServicesToRun;
                ServicesToRun = new ServiceBase[] 
            { 
                service
            };
                ServiceBase.Run(ServicesToRun);
            
#endif
        }
    }
}

using System.ServiceProcess;

namespace InternetExplorerUrlKiller
{
    internal static class Program
    {
        private static void Main()
        {
            var servicesToRun = new ServiceBase[] {new InternetExplorerUrlKillerService()};
            ServiceBase.Run(servicesToRun);
        }
    }
}

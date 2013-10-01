using System.Diagnostics;
using System.Linq;
using System.Threading;
using SHDocVw;

namespace InternetExplorerUrlKiller
{
    public class UrlKiller
    {
        private Thread _thread;

        public void Start()
        {
            _thread = new Thread(Execute);
            _thread.Start();
        }

        private void Execute()
        {
            while (true)
            {
                var shellWindows = new ShellWindows();
                foreach (var ieInst in from InternetExplorer ieInst in shellWindows let url = ieInst.LocationURL where url.Contains("Ombuds") select ieInst)
                {
                    ieInst.Quit();
                }
 
                // Sleep for 10 sec
                Thread.Sleep(10000);
            }
        }

        public void Stop()
        {
            if (_thread == null) return;
            _thread.Abort();
            _thread.Join();
        }
    }
}

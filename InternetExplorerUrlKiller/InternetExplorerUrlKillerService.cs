using System.ServiceProcess;

namespace InternetExplorerUrlKiller
{
    public partial class InternetExplorerUrlKillerService : ServiceBase
    {
        private UrlKiller _urlKiller = new UrlKiller();

        public InternetExplorerUrlKillerService()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            if (_urlKiller == null)
                _urlKiller = new UrlKiller();

            _urlKiller.Start();
        }

        protected override void OnStop()
        {
            if (_urlKiller != null)
                _urlKiller.Stop();
        }
    }
}

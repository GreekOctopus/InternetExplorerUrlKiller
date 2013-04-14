using System.ComponentModel;
using System.Configuration.Install;

namespace InternetExplorerUrlKiller
{
    [RunInstaller(true)]
    public partial class ProjectInstaller : Installer
    {
        public ProjectInstaller()
        {
            InitializeComponent();
        }

        private void ServiceInstallerAfterInstall(object sender, InstallEventArgs e)
        {

        }

        private void ServiceProcessInstallerAfterInstall(object sender, InstallEventArgs e)
        {

        }
    }
}

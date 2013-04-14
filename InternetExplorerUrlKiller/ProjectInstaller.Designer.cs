namespace InternetExplorerUrlKiller
{
    partial class ProjectInstaller
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.internetExplorerUrlKillerProcessInstaller = new System.ServiceProcess.ServiceProcessInstaller();
            this.internetExplorerUrlKillerServiceInstaller = new System.ServiceProcess.ServiceInstaller();
            // 
            // internetExplorerUrlKillerProcessInstaller
            // 
            this.internetExplorerUrlKillerProcessInstaller.Account = System.ServiceProcess.ServiceAccount.LocalSystem;
            this.internetExplorerUrlKillerProcessInstaller.Password = null;
            this.internetExplorerUrlKillerProcessInstaller.Username = null;
            this.internetExplorerUrlKillerProcessInstaller.AfterInstall += new System.Configuration.Install.InstallEventHandler(this.ServiceProcessInstallerAfterInstall);
            // 
            // internetExplorerUrlKillerServiceInstaller
            // 
            this.internetExplorerUrlKillerServiceInstaller.ServiceName = "Internet Explorer Url Killer";
            this.internetExplorerUrlKillerServiceInstaller.Description = "Internet Explorer Url Killer";
            this.internetExplorerUrlKillerServiceInstaller.DisplayName = "Internet Explorer Url Killer";
            this.internetExplorerUrlKillerServiceInstaller.AfterInstall += new System.Configuration.Install.InstallEventHandler(this.ServiceInstallerAfterInstall);
            // 
            // ProjectInstaller
            // 
            this.Installers.AddRange(new System.Configuration.Install.Installer[] {
            this.internetExplorerUrlKillerProcessInstaller,
            this.internetExplorerUrlKillerServiceInstaller});

        }

        #endregion

        private System.ServiceProcess.ServiceProcessInstaller internetExplorerUrlKillerProcessInstaller;
        private System.ServiceProcess.ServiceInstaller internetExplorerUrlKillerServiceInstaller;
    }
}
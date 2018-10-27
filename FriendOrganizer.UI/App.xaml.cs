using Autofac;
using FriendOrganizer.UI.StartUp;
using System.Windows;

namespace FriendOrganizer.UI
{
    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            var bootstrapper = new Bootstrapper();
            var container = bootstrapper.BootStrap();
            var mainWindow = container.Resolve<MainWindow>();
            MainWindow.Show();
        }
    }
}

using KMU.Wpf.View;
using System.Windows;

namespace KMU.Wpf;

public partial class App : Application
{
    protected override void OnStartup(StartupEventArgs e)
    {
        Bootstrapper.Start();

        MainWindow = Bootstrapper.Resolve<MainWindow>();
        MainWindow.Show();
    }

    protected override void OnExit(ExitEventArgs e)
    {
        try
        {
            MainWindow.Close();
        }
        catch (System.Exception) { }
    }
}
using KMU.Code.AccessLayer;
using KMU.Wpf.ViewModel;
using System.Windows;

namespace KMU.Wpf.View;

public partial class MainWindow : Window
{
    private readonly MainWindowViewModel _mainWindowViewModel;

    public MainWindow(MainWindowViewModel mainWindowViewModel)
    {
        _mainWindowViewModel = mainWindowViewModel;

        InitializeComponent();
        DataContext = _mainWindowViewModel;
    }

    private void Window_Loaded(object sender, RoutedEventArgs e)
    {
        _mainWindowViewModel.Loaded();
    }
}

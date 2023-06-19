using KMU.Code.AccessLayer;
using System.Windows;

namespace KMU.Wpf;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        CustomerAccessLayer customerAccessLayer = new();
        customerAccessLayer.GetCustomers();
    }
}

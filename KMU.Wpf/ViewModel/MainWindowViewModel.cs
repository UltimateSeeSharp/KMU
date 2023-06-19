using KMU.Code.AccessLayer;
using KMU.Data.Model;
using KMU.Wpf.Infrastructure;
using KMU.Code.AccessLayer.Interfaces;
using System.Collections.Generic;

namespace KMU.Wpf.ViewModel;

public class MainWindowViewModel : BaseViewModel
{
    private readonly ICustomerAccessLayer _customerAccessLayer;

    public MainWindowViewModel(ICustomerAccessLayer customerAccessLayer)
    {
        _customerAccessLayer = customerAccessLayer;
    }

    private List<Customer>? _customers = null;
    public List<Customer>? Customers
    {
        get => _customers;
        set
        {
            if(_customers == value) return;
            _customers = value;
            OnPropertyChanged();
        }
    }

    public void Loaded()
    {
        Customers = _customerAccessLayer.GetCustomers();
    }
}
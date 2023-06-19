using KMU.Code.AccessLayer;
using SimpleInjector;
using KMU.Code.AccessLayer.Interfaces;
using KMU.Wpf.View;
using KMU.Wpf.ViewModel;
using KMU.Data.Model;

namespace KMU.Wpf;

public static class Bootstrapper
{
    private static Container _container = new();

        public static Container Start()
        {
            _container.Register<ICustomerAccessLayer, CustomerAccessLayer>();
            _container.Register<IAddressAccessLayer, AddressAccessLayer>();
            _container.Register<ICountryAccessLayer, CountryAccessLayer>();
            _container.Register<IGenderAccessLayer, GenderAccessLayer>();
            _container.Register<IPaymentInfoAccessLayer, PaymentInfoAccessLayer>();
            _container.Register<IPaymentConditionAccessLayer, PaymentConditionAccessLayer>();

            _container.Register<MainWindowViewModel>();
            _container.Register<MainWindow>();

            _container.Verify();

            return _container;
        }

    public static T Resolve<T>() where T : class
    {
        return _container.GetInstance<T>();
    }
}
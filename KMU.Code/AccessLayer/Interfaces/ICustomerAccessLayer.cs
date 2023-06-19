using KMU.Data.Model;

namespace KMU.Code.AccessLayer.Interfaces;

public interface ICustomerAccessLayer
{
    List<Customer> GetCustomers();

    void AddCustomer(Customer customer);

    void EditCustomer(Customer customer);

    void DeleteCustomer(int id);

    Customer GetCustomerById(int id);
}
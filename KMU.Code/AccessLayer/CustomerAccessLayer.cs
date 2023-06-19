using KMU.Code.AccessLayer.Interfaces;
using KMU.Code.Extentions;
using KMU.Data.Model;
using System.Data.SqlClient;

namespace KMU.Code.AccessLayer;

public class CustomerAccessLayer : ICustomerAccessLayer
{
    private SqlConnection Connection => ConnectionHandler.GetSqlConnection();

    private GenderAccessLayer _genderAccessLayer = new();
    private AddressAccessLayer _addressAccessLayer = new();
    private PaymentInfoAccessLayer _paymentInfoAccessLayer = new();
    private PaymentConditionAccessLayer _paymentConditionAccessLayer = new();

    public List<Customer> GetCustomers()
    {
        List<Customer> customers = new();

        string query = "select * from Customer";
        SqlCommand command = new SqlCommand(query, Connection);

        try
        {
            using SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                int id = reader.GetInt32(0);
                string formOfAddress = reader.GetString(1);
                string firstname = reader.GetString(2);
                string lastname = reader.GetString(3);
                string atuNr = reader.GetString(4);
                decimal discount = reader.GetDecimal(5);
                int genderId = reader.GetInt32(6);
                int addressId = reader.GetInt32(7);
                int paymentInfoId = reader.GetInt32(8);
                int paymentConditionId = reader.GetInt32(9);

                Customer customer = new(id, formOfAddress, firstname, lastname, atuNr, discount, genderId, addressId, paymentInfoId, paymentConditionId);
                customers.Add(customer);
            }
            reader.Close();

            foreach (Customer customer in customers)
            {
                customer.Gender = _genderAccessLayer.GetGenderById(customer.GenderId);
                customer.Address = _addressAccessLayer.GetAddressById(customer.AddressId);
                customer.PaymentInfo = _paymentInfoAccessLayer.GetPaymentInfoById(customer.PaymentInfoId);
                customer.PaymentCondition = _paymentConditionAccessLayer.GetPaymentConditionById(customer.PaymentConditionId);
            }
        }
        catch (Exception) { throw; }

        return customers;
    }

    public void AddCustomer(Customer customer)
    {
        throw new NotImplementedException();
    }

    public void DeleteCustomer(int id)
    {
        throw new NotImplementedException();
    }

    public void EditCustomer(Customer customer)
    {
        throw new NotImplementedException();
    }

    public Customer GetCustomerById(int id)
    {
        throw new NotImplementedException();
    }
}

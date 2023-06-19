using KMU.Code.AccessLayer.Interfaces;
using KMU.Code.Extentions;
using KMU.Data.Model;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace KMU.Code.AccessLayer;

public class AddressAccessLayer : IAddressAccessLayer
{
    private SqlConnection Connection => ConnectionHandler.GetSqlConnection();

    private CountryAccessLayer _countryAccessLayer = new();

    public void AddAddress(Address address)
    {
        throw new NotImplementedException();
    }

    public void DeleteAddress(int id)
    {
        throw new NotImplementedException();
    }

    public void EditAddress(Address address)
    {
        throw new NotImplementedException();
    }

    public Address? GetAddressById(int searchId)
    {
        Address? address = null;

        string query = $"select * from Addresses where AddressId = {searchId}";

        SqlCommand command = new SqlCommand(query, Connection);

        int countryId = 0;

        using SqlDataReader reader = command.ExecuteReader();
        while (reader.Read())
        {
            int id = reader.GetInt32(0);
            string streetName = reader.GetString(1);
            string streetNr = reader.GetString(2);
            string doorNr = reader.GetString(3);
            int plz = reader.GetInt32(4);
            string city = reader.GetString(5);
            countryId = reader.GetInt32(6);

            address = new(id, streetName, streetNr, doorNr, plz, city, null!);
        }
        reader.Close();

        address!.Country = _countryAccessLayer.GetCountryById(countryId);

        return address;
    }

    public List<Address> GetAddresses()
    {
        throw new NotImplementedException();
    }
}
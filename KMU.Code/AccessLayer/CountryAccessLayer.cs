using KMU.Code.AccessLayer.Interfaces;
using KMU.Code.Extentions;
using KMU.Data.Model;
using System.Data.SqlClient;

namespace KMU.Code.AccessLayer;

public class CountryAccessLayer : ICountryAccessLayer
{
    private SqlConnection Connection => ConnectionHandler.GetSqlConnection();

    public void AddCountry(Country country)
    {
        throw new NotImplementedException();
    }

    public void EditCountry(Country country)
    {
        throw new NotImplementedException();
    }

    public List<Country> GetCountries()
    {
        throw new NotImplementedException();
    }

    public Country? GetCountryById(int searchId)
    {
        Country? country = null;
        string query = "select * from Countries " +
                      $"where CountryId = {searchId}";

        SqlCommand command = new SqlCommand(query, Connection);

        using SqlDataReader reader = command.ExecuteReader();
        while (reader.Read())
        {
            int id = reader.GetInt32(0);
            string localName = reader.GetString(1);
            string internationalName = reader.GetString(2);

            country = new(id, localName, internationalName);
        }
        reader.Close();

        return country;
    }

    public void RemoveCountry(int id)
    {
        throw new NotImplementedException();
    }
}

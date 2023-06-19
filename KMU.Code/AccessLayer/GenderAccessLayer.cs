using KMU.Code.AccessLayer.Interfaces;
using KMU.Code.Extentions;
using KMU.Data.Model;
using System.Data.SqlClient;

namespace KMU.Code.AccessLayer;

public class GenderAccessLayer : IGenderAccessLayer
{
    private SqlConnection Connection => ConnectionHandler.GetSqlConnection();

    public List<Gender> GetGenders()
    {
        throw new NotImplementedException();
    }

    public Gender? GetGenderById(int searchId)
    {
        Gender? gender = null;

        string query = $"select * from Genders where GenderId = {searchId}";

        SqlCommand command = new SqlCommand(query, Connection);

        using SqlDataReader reader = command.ExecuteReader();
        while (reader.Read())
        {
            int id = reader.GetInt32(0);
            string genderName = reader.GetString(1);

            gender = new(id, genderName);
        }
        reader.Close();

        return gender;
    }
}

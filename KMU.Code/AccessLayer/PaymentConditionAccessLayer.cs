using KMU.Code.AccessLayer.Interfaces;
using KMU.Code.Extentions;
using KMU.Data.Model;
using System.Data.SqlClient;

namespace KMU.Code.AccessLayer;

public class PaymentConditionAccessLayer : IPaymentConditionAccessLayer
{
    private SqlConnection Connection => ConnectionHandler.GetSqlConnection();

    public void AddPaymentCondition(PaymentCondition condition)
    {
        throw new NotImplementedException();
    }

    public void EditPaymentCondition(PaymentCondition condition)
    {
        throw new NotImplementedException();
    }

    public PaymentCondition? GetPaymentConditionById(int searchId)
    {
        PaymentCondition? paymentCondition = null;

        string query = $"select * from PaymentCondition where PaymentConditionId = {searchId}";

        SqlCommand command = new SqlCommand(query, Connection);

        using SqlDataReader reader = command.ExecuteReader();
        while (reader.Read())
        {
            int id = reader.GetInt32(0);
            string condition = reader.GetString(1);

            paymentCondition = new(id, condition);
        }
        reader.Close();

        return paymentCondition;
    }

    public List<PaymentCondition> GetPaymentConditions()
    {
        throw new NotImplementedException();
    }

    public void RemovePaymentCondition(int id)
    {
        throw new NotImplementedException();
    }
}
using KMU.Code.AccessLayer.Interfaces;
using KMU.Code.Extentions;
using KMU.Data.Model;
using System.Data.SqlClient;

namespace KMU.Code.AccessLayer;

public class PaymentInfoAccessLayer : IPaymentInfoAccessLayer
{
    private SqlConnection Connection => ConnectionHandler.GetSqlConnection();

    public void AddPaymentInfo(PaymentInfo paymentInfo)
    {
        throw new NotImplementedException();
    }

    public void DeletePaymentInfo(int id)
    {
        throw new NotImplementedException();
    }

    public void EditPaymentInfo(PaymentInfo paymentInfo)
    {
        throw new NotImplementedException();
    }

    public PaymentInfo? GetPaymentInfoById(int searchId)
    {
        PaymentInfo? paymentInfo = null;

        string query = $"select * from PaymentInfo where PaymentInfoId = {searchId}";

        SqlCommand command = new SqlCommand(query, Connection);

        using SqlDataReader reader = command.ExecuteReader();
        while (reader.Read())
        {
            int id = reader.GetInt32(0);
            string bankName = reader.GetString(1);
            string iban = reader.GetString(2);
            string bic = reader.GetString(3);

            paymentInfo = new(id, bankName, iban, bic);
        }
        reader.Close();

        return paymentInfo;
    }

    public List<PaymentInfo> GetPaymentInfos()
    {
        throw new NotImplementedException();
    }
}
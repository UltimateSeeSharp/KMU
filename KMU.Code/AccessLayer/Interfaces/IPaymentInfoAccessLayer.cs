using KMU.Data.Model;

namespace KMU.Code.AccessLayer.Interfaces;

public interface IPaymentInfoAccessLayer
{
    List<PaymentInfo> GetPaymentInfos();

    void AddPaymentInfo(PaymentInfo paymentInfo);

    void EditPaymentInfo(PaymentInfo paymentInfo);

    void DeletePaymentInfo(int id);

    PaymentInfo GetPaymentInfoById(int id);
}

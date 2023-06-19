namespace KMU.Data.Model;

public class PaymentInfo
{
    public PaymentInfo(int id, string bankName, string iban, string bic)
    {
        Id = id;
        BankName = bankName;
        IBAN = iban;
        BIC = bic;
    }

    public int Id { get; set; }

    public string BankName { get; set; }

    public string IBAN { get; set; }

    public string BIC { get; set; }
}
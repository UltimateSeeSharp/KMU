namespace KMU.Data.Model;

public class Customer
{
    public Customer(
        int id,
        string formOfAddress,
        string firstname,
        string lastname,
        string atuNr,
        decimal discount,
        int genderId,
        int addressId,
        int paymentInfoId,
        int paymentConditionId)
    {
        Id = id;
        FormOfAddress = formOfAddress;
        Firstname = firstname;
        Lastname = lastname;
        AtuNr = atuNr;
        Discount = discount;
        GenderId = genderId;
        AddressId = addressId;
        PaymentInfoId = paymentInfoId;
        PaymentConditionId = paymentConditionId;
    }

    public int Id { get; set; }

    public string FormOfAddress { get; set; }

    public string Firstname { get; set; }

    public string Lastname { get; set; }

    public string AtuNr { get; set; }

    public decimal Discount { get; set; }

    public int GenderId { get; set; }
    public Gender Gender { get; set; }

    public int AddressId { get; set; }
    public Address Address { get; set; }

    public int PaymentInfoId { get; set; }
    public PaymentInfo PaymentInfo { get; set; }

    public int PaymentConditionId { get; set; }
    public PaymentCondition PaymentCondition { get; set; }
}
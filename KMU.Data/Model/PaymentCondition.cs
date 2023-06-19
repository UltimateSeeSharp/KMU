namespace KMU.Data.Model;

public class PaymentCondition
{
    public PaymentCondition(int id, string condition)
    {
        Id = id;
        Condition = condition;
    }

    public int Id { get; set; }

    public string Condition { get; set; }
}
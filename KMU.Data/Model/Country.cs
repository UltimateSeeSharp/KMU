namespace KMU.Data.Model;

public class Country
{
    public Country(int id, string localName, string internationalName)
    {
        Id = id;
        LocalName = localName;
        InternationalName = internationalName;
    }

    public int Id { get; set; }

    public string LocalName { get; set; }

    public string InternationalName { get; set; }
}
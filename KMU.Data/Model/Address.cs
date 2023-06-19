namespace KMU.Data.Model;

public class Address
{
    public Address(
        int id, 
        string streetName, 
        string streetNr, 
        string doorNr, 
        int plz, 
        string city, 
        Country country)
    {
        Id = id;
        Streetname = streetName;
        StreetNr = streetNr;
        DoorNr = doorNr;
        Plz = plz;
        City = city;
        Country = country;
    }

    public int Id { get; set; }

    public string Streetname { get; set; }

    public string StreetNr { get; set; }

    public string DoorNr { get; set; }

    public int Plz { get; set; }

    public string City { get; set; }

    public Country Country { get; set; }
}
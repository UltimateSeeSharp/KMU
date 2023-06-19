namespace KMU.Data.Model;

public class Gender
{
    public Gender(int id, string genderName)
    {
        Id = id;
        GenderName = genderName;
    }

    public int Id { get; set; }

    public string GenderName { get; set; }
}
using KMU.Data.Model;

namespace KMU.Code.AccessLayer.Interfaces;

public interface IGenderAccessLayer
{
    List<Gender> GetGenders();

    Gender GetGenderById(int id);
}
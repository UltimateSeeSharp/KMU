using KMU.Data.Model;

namespace KMU.Code.AccessLayer.Interfaces;

internal interface IGenderAccessLayer
{
    List<Gender> GetGenders();

    Gender GetGenderById(int id);
}
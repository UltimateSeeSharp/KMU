using KMU.Data.Model;

namespace KMU.Code.AccessLayer.Interfaces;

public interface IAddressAccessLayer
{
    List<Address> GetAddresses();

    void AddAddress(Address address);

    void EditAddress(Address address);

    void DeleteAddress(int id);

    Address GetAddressById(int id);
}
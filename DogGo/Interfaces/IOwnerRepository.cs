using DogGo.Models;

namespace DogGo.Interfaces
{
    public interface IOwnerRepository
    {
        List<Owner> GetAllOwners();
        Owner GetOwnersById(int id);
    }
}

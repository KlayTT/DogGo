using DogGo.Models;

namespace DogGo.Interfaces
{
    public interface IDogRepository
    {
            List<Dog> GetAllDogs();
            Dog GetDogsById(int id);
    }
}

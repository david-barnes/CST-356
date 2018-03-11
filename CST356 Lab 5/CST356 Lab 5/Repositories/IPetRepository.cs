using System.Collections.Generic;
using CST356_Lab_5.Data.Entities;

namespace CST356_Lab_5.Repositories
{
    public interface IPetRepository
    {
        Pet GetPet(int id);

        IEnumerable<Pet> GetPetsForUser();

        void SavePet(Pet pet);

        void UpdatePet(Pet user);

        void DeletePet(int id);
    }
}

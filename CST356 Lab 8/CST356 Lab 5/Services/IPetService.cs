using System;
using System.Collections.Generic;
using CST356_Lab_5.Models.View;

namespace CST356_Lab_5.Services
{
    public interface IPetService
    {
        PetViewModel GetPet(int id);

        IEnumerable<PetViewModel> GetPetsForUser(string userId);

        void SavePet(string userId, PetViewModel pet);

        void UpdatePet(PetViewModel user);

        void DeletePet(int id);
    }
}

﻿using System.Collections.Generic;
using System.Linq;
using CST356_Lab_5.Models;
using CST356_Lab_5.Data.Entities;

namespace CST356_Lab_5.Repositories
{
    public class PetRepository : IPetRepository
    {
        private readonly AppDbContext _dbContext;

        public PetRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Pet GetPet(int id)
        {
            return _dbContext.Pets.Find(id);
        }

        public IEnumerable<Pet> GetPetsForUser(string userId)
        {
            return _dbContext.Pets.Where(pet => pet.UserId == userId).ToList();
        }

        public void SavePet(Pet pet)
        {
            _dbContext.Pets.Add(pet);

            _dbContext.SaveChanges();
        }

        public void UpdatePet(Pet pet)
        {
            _dbContext.SaveChanges();
        }

        public void DeletePet(int id)
        {
            var pet = _dbContext.Pets.Find(id);

            if (pet == null) return;

            _dbContext.Pets.Remove(pet);
            _dbContext.SaveChanges();
        }
    }
}
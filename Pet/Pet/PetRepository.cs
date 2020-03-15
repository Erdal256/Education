using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Pet.Models;

namespace Pet
{
    public class PetRepository : Interfaces.IPetRepository
    {
        private readonly DataContext _dataContext;

        public PetRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public Models.Pet Delete(int Id)
        {
            var pet = Get(Id);
            _dataContext.Pets.Remove(pet);
            _dataContext.SaveChanges();
            return pet;
        }

        public Models.Pet Get(int Id)
        {
            return _dataContext.Pets.Find(Id);
        }

        public List<Models.Pet> GetAll()
        {
            return _dataContext.Pets.ToList();
        }

        public Models.Pet Insert(Models.Pet pet)
        {
            _dataContext.Pets.Add(pet);
            _dataContext.SaveChanges();
            return pet;
        }

        public Models.Pet Update(Models.Pet pet)
        {
            _dataContext.Pets.Update(pet);
            _dataContext.SaveChanges();
            return pet;
        }
    }
}

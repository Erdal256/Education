using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pet.Interfaces
{
    public interface IPetRepository
    {

        List<Pet.Models.Pet> GetAll();
        Pet.Models.Pet Get(int Id);
        Pet.Models.Pet Insert(Pet.Models.Pet pet);
        Pet.Models.Pet Update(Pet.Models.Pet pet);
        Pet.Models.Pet Delete(int Id);

    
    }
}

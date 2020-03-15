using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Pet.Interfaces;

namespace Pet.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PetsController : ControllerBase
    {
        
        Interfaces.IPetRepository _petRepository;

        public PetsController(IPetRepository petRepository)
        {
            _petRepository = petRepository;
        }

        [HttpGet]
        public IActionResult GetAll() {
            var pets = _petRepository.GetAll();

            return new JsonResult(pets);
        }

        [HttpGet("{id}")]
        public IActionResult getId(int Id)
        {
            return new JsonResult(_petRepository.Get(Id));
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int Id)
        {
            return new JsonResult(_petRepository.Delete(Id));
        }
        [HttpPut]
        public IActionResult Update([FromBody] Pet.Models.Pet pet)
        {
            _petRepository.Update(pet);
            return Ok();
        }
        [HttpPost]
        public IActionResult Insert([FromBody] Pet.Models.Pet pet)
        {
            _petRepository.Insert(pet);
            return Ok();
        }


    }
}
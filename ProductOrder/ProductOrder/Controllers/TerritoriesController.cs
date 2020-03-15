using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ProductOrder.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TerritoriesController : ControllerBase
    {
        private readonly Interfaces.IUnitOfWork _unitOfWork;

        public TerritoriesController(Interfaces.IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var territories = _unitOfWork.TerritoryRepository.GetAll();
            return new JsonResult(territories);
        }
        [HttpPost]
        public IActionResult Insert([FromBody] Models.Territory territory)
        {
            _unitOfWork.TerritoryRepository.Insert(territory);
            _unitOfWork.Complete();
            return new JsonResult(territory);
        }
        [HttpPut]
        public IActionResult Update([FromBody] Models.Territory territory)
        {
            _unitOfWork.TerritoryRepository.Update(territory);
            _unitOfWork.Complete();
            return new JsonResult(territory);

        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _unitOfWork.TerritoryRepository.Delete(id);
            _unitOfWork.Complete();
            return new JsonResult("ok");
        }
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var territories = _unitOfWork.TerritoryRepository.GetById(id);
            return new JsonResult(territories);
        }
    }
}
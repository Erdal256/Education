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
    public class EmployeeTerritoriesController : ControllerBase
    {
        private readonly Interfaces.IUnitOfWork _unitOfWork;

        public EmployeeTerritoriesController(Interfaces.IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var employeeTerritories = _unitOfWork.CustomerRepository.GetAll();
            return new JsonResult(employeeTerritories);
        }
        [HttpPost]
        public IActionResult Insert([FromBody] Models.EmployeeTerritory employeeTerritory)
        {
            _unitOfWork.EmployeeTerritoryRepository.Insert(employeeTerritory);
            _unitOfWork.Complete();
            return new JsonResult(employeeTerritory);
        }
        [HttpPut]
        public IActionResult Update([FromBody] Models.EmployeeTerritory employeeTerritory)
        {
            _unitOfWork.EmployeeTerritoryRepository.Update(employeeTerritory);
            _unitOfWork.Complete();
            return new JsonResult(employeeTerritory);

        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _unitOfWork.EmployeeTerritoryRepository.Delete(id);
            _unitOfWork.Complete();
            return new JsonResult("ok");
        }
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var employeeTerritories = _unitOfWork.EmployeeTerritoryRepository.GetById(id);
            return new JsonResult(employeeTerritories);
        }
    }
}
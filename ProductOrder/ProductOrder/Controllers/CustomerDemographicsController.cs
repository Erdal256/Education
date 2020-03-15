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
    public class CustomerDemographicsController : ControllerBase
    {
        private readonly Interfaces.IUnitOfWork _unitOfWork;

        public CustomerDemographicsController(Interfaces.IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var customerDemographics = _unitOfWork.CustomerDemographicRepository.GetAll();
            return new JsonResult(customerDemographics);
        }
        [HttpPost]
        public IActionResult Insert([FromBody] Models.CustomerDemographic customerDemographic)
        {
            _unitOfWork.CustomerDemographicRepository.Insert(customerDemographic);
            _unitOfWork.Complete();
            return new JsonResult(customerDemographic);
        }
        [HttpPut]
        public IActionResult Update([FromBody] Models.CustomerDemographic customerDemographic)
        {
            _unitOfWork.CustomerDemographicRepository.Update(customerDemographic);
            _unitOfWork.Complete();
            return new JsonResult(customerDemographic);

        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _unitOfWork.CustomerDemographicRepository.Delete(id);
            _unitOfWork.Complete();
            return new JsonResult("ok");
        }
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var customerDemographics = _unitOfWork.CustomerDemographicRepository.GetById(id);
            return new JsonResult(customerDemographics);
        }
    }
}
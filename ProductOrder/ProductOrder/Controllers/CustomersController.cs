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
    public class CustomersController : ControllerBase
    {
        private readonly Interfaces.IUnitOfWork _unitOfWork;

        public CustomersController(Interfaces.IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var customers = _unitOfWork.CustomerRepository.GetAll();
            return new JsonResult(customers);
        }
        [HttpPost]
        public IActionResult Insert([FromBody] Models.Customer customer)
        {
            _unitOfWork.CustomerRepository.Insert(customer);
            _unitOfWork.Complete();
            return new JsonResult(customer);
        }
        [HttpPut]
        public IActionResult Update([FromBody] Models.Customer customer)
        {
            _unitOfWork.CustomerRepository.Update(customer);
            _unitOfWork.Complete();
            return new JsonResult(customer);

        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _unitOfWork.CustomerRepository.Delete(id);
            _unitOfWork.Complete();
            return new JsonResult("ok");
        }
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var customers = _unitOfWork.CustomerRepository.GetById(id);
            return new JsonResult(customers);
        }
    }
}
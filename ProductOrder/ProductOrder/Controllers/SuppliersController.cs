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
    public class SuppliersController : ControllerBase
    {
        private readonly Interfaces.IUnitOfWork _unitOfWork;

        public SuppliersController(Interfaces.IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var suppliers = _unitOfWork.SupplierRepository.GetAll();
            return new JsonResult(suppliers);
        }
        [HttpPost]
        public IActionResult Insert([FromBody] Models.Supplier supplier)
        {
            _unitOfWork.SupplierRepository.Insert(supplier);
            _unitOfWork.Complete();
            return new JsonResult(supplier);
        }
        [HttpPut]
        public IActionResult Update([FromBody] Models.Supplier supplier)
        {
            _unitOfWork.SupplierRepository.Update(supplier);
            _unitOfWork.Complete();
            return new JsonResult(supplier);

        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _unitOfWork.SupplierRepository.Delete(id);
            _unitOfWork.Complete();
            return new JsonResult("ok");
        }
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var suppliers = _unitOfWork.SupplierRepository.GetById(id);
            return new JsonResult(suppliers);
        }
    }
}
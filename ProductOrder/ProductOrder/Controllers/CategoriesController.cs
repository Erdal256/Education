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
    public class CategoriesController : ControllerBase
    {
        private readonly Interfaces.IUnitOfWork _unitOfWork;

        public CategoriesController(Interfaces.IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var categories = _unitOfWork.CategoryRepository.GetAll();
            return new JsonResult(categories);
        }
        [HttpPost]
        public IActionResult Insert([FromBody] Models.Category category)
        {
            _unitOfWork.CategoryRepository.Insert(category);
            _unitOfWork.Complete();
            return new JsonResult(category);
        }
        [HttpPut]
        public IActionResult Update([FromBody] Models.Category category)
        {
            _unitOfWork.CategoryRepository.Update(category);
            _unitOfWork.Complete();
            return new JsonResult(category);

        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _unitOfWork.CategoryRepository.Delete(id);
            _unitOfWork.Complete();
            return new JsonResult("ok");
        }
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var categories = _unitOfWork.CategoryRepository.GetById(id);
            return new JsonResult(categories);
        }
    }
}
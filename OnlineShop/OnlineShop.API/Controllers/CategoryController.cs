using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineShop.API.interfaces;

namespace OnlineShop.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        ICategoryRepository _categoryRepository;
        public CategoryController(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
            //return new JsonResult(categoryRepository);  
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var category = _categoryRepository.GetAll();
            return Ok(category);

        }
    }
}

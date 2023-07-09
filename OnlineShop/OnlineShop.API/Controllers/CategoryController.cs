using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineShop.API.interfaces;
using OnlineShop.API.Models;

namespace OnlineShop.API.Controllers
{
    [Route("api/[controller]/{action}")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        ICategoryRepository _categoryRepository;
        public CategoryController(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
             
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var category = _categoryRepository.GetAll();
            return Ok(category);
        }
        [HttpGet]
        public IActionResult GetById(int Id)
        {
            var category = _categoryRepository.GetCategory(Id);
            return Ok(category);
        }

        [HttpPost]
        public IActionResult Add([FromBody] Category category)
        {

            try
            {
                bool isSaved = _categoryRepository.Add(category);
                if (isSaved)
                {
                    return Ok("Category has been saved");
                }
                return BadRequest("Category Saved faild");
                
            }catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPut]
        public IActionResult Edit([FromBody] Category category)
        {

            try
            {
                bool isSaved = _categoryRepository.Edit(category);
                if (isSaved)
                {
                    return Ok("Category has been modified");
                }
                return BadRequest("Category modified faild");

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {

            try
            {
                bool isSaved = _categoryRepository.Delete(id);
                if (isSaved)
                {
                    return Ok("Category has beed delted");
                }
                return BadRequest("Category cannot deleted");

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }


}

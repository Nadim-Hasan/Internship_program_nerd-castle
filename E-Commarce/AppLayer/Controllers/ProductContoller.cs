using BussinessLogicLayer.DTOs.CustomerDTOs;
using BussinessLogicLayer.Services.CustomerServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AppLayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        // POST: api/Product
        [HttpPost]
        public IActionResult InsertProduct([FromBody] ProductDTO product)
        {



            
            var insertedProduct = ProductService.InsertProduct(product);

          
            if (insertedProduct != null)
            {
                return CreatedAtAction(nameof(InsertProduct), insertedProduct);
            }

            // If the product insertion failed, return HTTP status code 500 Internal Server Error
            return StatusCode(StatusCodes.Status500InternalServerError, "Failed to insert the product.");
        }
    }
}

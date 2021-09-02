using DevReviews.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace DevReviews.API.Controllers
{
    [ApiController]
    [Route("api/products/{productId}/productreviews")]
    public class ProductReviewsController : ControllerBase
    {
        // GET api/products/1/productreviews/5
        [HttpGet("{id}")]
        public IActionResult GetById(int productId, int id) {
            // Se não existir com o id especificado, retornar NotFound()
            return Ok();
        }

        // POST api/products/1/productreviews
        [HttpPost]
        public IActionResult Post(int productId, AddProductReviewInputModel model) {
            // Se estiver com dados inválidos, retornar BadRequest()
            
            return CreatedAtAction(nameof(GetById), new { id = 1, productId = 2 }, model);
        }
    }
}
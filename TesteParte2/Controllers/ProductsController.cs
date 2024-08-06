using Microsoft.AspNetCore.Mvc;
using TesteParte2.Interface;
using TesteParte2.Repository;

namespace TesteParte2.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    [Produces("application/json")]

    public class ProductsController : ControllerBase
    {
        private IProductsRepository _productsRepository { get; set; }
        public ProductsController()
        {
            _productsRepository = new ProductsRepository();    
        }
        
        [HttpGet]
        public IActionResult Get() 
        {
            try
            {
                return Ok(_productsRepository.GetAll());
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}

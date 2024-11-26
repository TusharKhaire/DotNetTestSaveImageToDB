using IRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model;

namespace DotNetTestSaveImageToDB.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProduct prod;
        public ProductController(IProduct _prod)
        {
            this.prod = _prod;
        }
        [HttpPost("SaveProduct")]
        public async Task<IActionResult> SaveProduct(Product product)
        {
            var isSave=await prod.SaveProduct(product);
            return Ok();
        }
    }
}

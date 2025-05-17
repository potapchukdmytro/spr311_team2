using Microsoft.AspNetCore.Mvc;

namespace team2.Controllers
{
    [ApiController]
    [Route("api/product")]
    public class ProductController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok();
        }
    }
}

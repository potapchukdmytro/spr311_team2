using Microsoft.AspNetCore.Mvc;

namespace spr311_team2.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetById(int id)
        {
            return Ok();
        }

        [HttpPost]
        public IActionResult Create()
        {
            return Ok();
        }

        [HttpPut]
        public IActionResult Update()
        {
            return Ok();
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            return Ok();
        }
    }
}

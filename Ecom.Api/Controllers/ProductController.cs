using Microsoft.AspNetCore.Mvc;

namespace Ecom.Api.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class ProductController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("helllo");
        }

    }
}

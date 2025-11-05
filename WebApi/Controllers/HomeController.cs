using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Welcome to the Home Controller!");
        }

        [HttpGet("GetInfo")]
        public IActionResult GetInfo()
        {
            var info = new
            {
                Application = "WebApi",
                Version = "1.0.0",
                Description = "This is the Home Controller providing basic information."
            };
            return Ok(info);
        }

      
        
    }
}

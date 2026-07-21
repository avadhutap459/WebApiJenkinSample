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
            return Ok("Welcome to the Home Controller! Avadhut Parab");
        }

        [HttpGet("GetEBS")]
        public IActionResult GetEBS()
        {
            return Ok("AWS EBS");
        }
        [HttpGet("GetEBSPart")]
        public IActionResult GetEBSPart()
        {
            return Ok("AWS EBS");
        }

        [HttpGet("PipeLine")]
        public IActionResult GetPipeLine()
        {
            return Ok("Hello Pipeline Executed");
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

        [HttpGet("GetInformation1")]
        public IActionResult GetInformation()
        {
            var info = new
            {
                Application = "WebApi2",
                Version = "1.1.0",
                Description = "This is the Home Controller providing basic information."
            };
            return Ok(info);
        }
        
    }
}

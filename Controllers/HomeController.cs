using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Nlog.Library.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            _logger.LogDebug(1, "NLog injected into HomeController");
        }

        [HttpGet("[action]")]
        public IActionResult Get()
        {
            _logger.LogInformation("Hello, this is the Get API Log!");
            return NoContent(); 
        }
    }
}

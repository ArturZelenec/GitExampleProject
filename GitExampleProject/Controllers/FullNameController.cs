using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GitExampleProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FullNameController : ControllerBase
    {
        private readonly ILogger<WeatherForecastController> _logger;

        public FullNameController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Get()
        {
            
            string fullName = "Artur Z.";
           _logger.LogInformation("Bla bla bla bla");
            return Ok(new { FullName = fullName });
        }
    }
}

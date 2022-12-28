using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GitExampleProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FullNameController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new { FullName = "Artur Z." });
        }
    }
}

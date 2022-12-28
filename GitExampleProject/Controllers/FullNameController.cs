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
            string fullName = "Artur Z.";
            return Ok(new { FullName =  fullName});
        }
    }
}

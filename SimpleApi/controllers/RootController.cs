using Microsoft.AspNetCore.Mvc;

namespace BlogApp.Controllers
{
    [ApiController]
    [Route("/")]
    public class RootController : ControllerBase
    {
        [HttpGet]
        public IActionResult RootHandler()
        {
            return Ok(new { success = true, message = "Server is Active" });
        }
    }
}

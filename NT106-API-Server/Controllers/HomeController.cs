using Microsoft.AspNetCore.Mvc;
using NT106_WebServer.Models;
using System.Text;

namespace NT106_API_Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : Controller
    {
        [HttpGet]
        [Route("test")]
        public IActionResult Test()
        {
            return Ok("Tester");
        }        
    }
}

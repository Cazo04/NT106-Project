using Microsoft.AspNetCore.Mvc;
using NT106_WebServer.Models;

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
        [HttpPost]
        [Route("login")]
        public IActionResult Login(SignInModel model)
        {
            if (ModelState.IsValid)
            {
                UserModel user = new UserModel();
                if (user.SignInUser(model))
                {
                    return Ok("Login success");
                } else
                {
                    ModelState.AddModelError("Password", "Username or password is incorrect.");
                }                    
            }
            return BadRequest(ModelState);
        }
    }
}

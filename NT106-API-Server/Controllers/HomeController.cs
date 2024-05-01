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
        [Route("signup")]
        [HttpPost]
        public IActionResult SignUp(SignUpModel model)
        {
            if (ModelState.IsValid)
            {
                UserModel user = new UserModel();
                user.Username = model.Username;
                user.FullName = model.FullName;
                user.Email = model.Email;
                user.DateOfBirth = model.Birthdate;
                user.Password = model.Password;
                user.SignUpUser();
                return View("SignIn");
            }
            return View(model);
        }
        [Route("signupchecker")]
        [HttpPost]
        public IActionResult SignUpChecker(SignUpModel model)
        {
            if (ModelState.IsValid)
            {
                return Ok();
            }
            else
            {
                StringBuilder builder1 = new StringBuilder();
                Dictionary<string, string> response = new System.Collections.Generic.Dictionary<string, string>();
                foreach (var key in ModelState.Keys)
                {
                    var state = ModelState[key];
                    if (state.Errors.Any())
                    {
                        foreach (var error in state.Errors)
                        {
                            if (!response.ContainsKey(key))
                                response.Add(key, error.ErrorMessage);
                        }
                    }
                }
                return Ok(response);
            }
        }
    }
}

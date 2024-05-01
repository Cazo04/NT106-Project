using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using NT106_WebServer.Models;
using System.Text;

namespace NT106_API_Server.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        [Route("signin")]
        [HttpPost]      
        public IActionResult Login(SignInModel model)
        {
            if (ModelState.IsValid)
            {
                UserModel user = new UserModel();
                if (user.SignInUser(model))
                {
                    UserToken userToken = new UserToken
                    {
                        UserId = user.Id,
                        Token = TokenService.GenerateUUID(),
                        Expires = DateTime.Now.AddDays(30),
                        IsRevoked = false
                    };
                    if (!TokenService.InsertUserToken(userToken))
                    {
                        userToken.Token = TokenService.GetTokenUserById(user.Id);
                    }

                    return Ok(userToken);
                }
                else
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
                return Ok();
            }
            return BadRequest();
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
        [Route("checktoken")]
        [HttpGet]
        [UserValidateToken]
        public IActionResult CheckToken()
        {
            return Ok("Hello, User!");
        }
        [Route("getverybasicuser")]
        [HttpGet]
        [UserValidateToken]
        public IActionResult GetVeryBasicUser()
        {
            string token = Request.Headers["Authorization"].ToString().Replace("Bearer ", "");
            UserModel user = UserModel.GetVeryBasicUserByToken(token);
            if (user == null)
            {
                return BadRequest("Error: User not found.");
            }
            return Ok(user);
        }
    }

    public class UserValidateTokenAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            string token = context.HttpContext.Request.Headers["Authorization"];
            if (string.IsNullOrEmpty(token))
            {
                context.Result = new UnauthorizedResult();
                return;
            }
            TokenStatus status = TokenService.GetUserTokenStatus(token.ToString().Replace("Bearer ", ""));
            if (status != TokenStatus.OK)
            {
                context.Result = new UnauthorizedResult();
                return;
            }
            base.OnActionExecuting(context);
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Newtonsoft.Json.Linq;
using NT106_WebServer.Models;

namespace NT106_API_Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AdminController : Controller
    {
        [Route("login")]
        [HttpPost]
        public IActionResult Login(SignInModel model)
        {
            if (ModelState.IsValid)
            {
                AdminModel admin = new AdminModel();
                if (admin.SignIn(model))
                {
                    TokenStatus result = admin.VerifyRefreshTokenByAdminId(admin.Username);
                    AdminToken token = new AdminToken();
                    if (result == TokenStatus.OK)
                    {
                        token = admin.TempAdminToken;
                        return Ok(token);
                    }
                    else if (result == TokenStatus.NotExist)
                    {
                        token = new AdminToken
                        {
                            AdminId = admin.Username,
                            Token = Guid.NewGuid().ToString(),
                            Expires = DateTime.Now.AddDays(60),
                            IsRevoked = false
                        };
                        admin.InsertAdminToken(token);
                        return Ok(token);
                    }
                    else if (result == TokenStatus.Revoked)
                    {
                        ModelState.AddModelError("UsernameOrEmail", "Your account has been banned.");
                    }
                }
                else
                {
                    ModelState.AddModelError("Password", "Username or password is incorrect.");
                }
            }
            return BadRequest(ModelState);
        }

        [Route("checktoken")]
        [HttpGet]
        [AdminValidateToken]
        public IActionResult CheckToken()
        {
            return Ok("Hello, Admin!");
        }

        [Route("moviesmanager")]
        [HttpGet]
        [AdminValidateToken]
        public IActionResult MoviesManager([FromQuery] int offset)
        {
            List<MovieModel.Movie> movies = new List<MovieModel.Movie>();
            movies = MovieModel.Get100MoviesLowDetail(offset);
            return Ok(movies);
        }

        [Route("moviescount")]
        [HttpGet]
        [AdminValidateToken]
        public IActionResult MoviesCount()
        {
            int count = MovieModel.GetTotalMovies();
            return Ok(count);
        }
    }

    public class AdminValidateTokenAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            base.OnActionExecuting(context);

            var token = context.HttpContext.Request.Headers["Authorization"].ToString().Replace("Bearer ", "");

            if (!IsValidToken(token))
            {
                context.Result = new UnauthorizedResult();
            }
        }

        private bool IsValidToken(string token)
        {
            TokenStatus result = AdminModel.VerifyRefreshToken(token);
            return result == TokenStatus.OK;
        }
    }
}

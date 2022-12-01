using bricksnetcoreapi.Models;
using bricksnetcoreapi.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace bricksnetcoreapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly IUserRepository _repository;
        public LoginController(IUserRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        [Route("getuser")]
        public IActionResult GetUsers()
        {
            return Ok();
        }

        [HttpPost]
        [Route("validateuser")]
        public IActionResult Login(UserModel user)
        {
            var result = _repository.ValidateUser(user);
            return Ok(result);
        }

        [HttpPost]
        [Route("register")]
        public IActionResult CreateUser(UserModel user)
        {
            return Ok();
        }
    }
}

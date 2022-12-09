using bricksnetcoreapi.Models;
using bricksnetcoreapi.Models.dtos;
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
            var result = _repository.GetUsers();
            return Ok(result);
        }

        [HttpPost]
        [Route("validateuser")]
        public IActionResult Login(UserDTO user)
        {
            IActionResult response = Unauthorized();
            var result = _repository.ValidateUser(user);
            if (result!=null)
            {
              var jwtToken=  _repository.GenerateJwtToken(user);
                response = Ok(new { token = jwtToken});
            }
            return response;
        }

        [HttpPost]
        [Route("register")]
        public IActionResult CreateUser(UserDTO user)
        {
            return Ok();
        }

        [HttpDelete]
        [Route("deleteuser")]
        public IActionResult DeleteUser()
        { 



            UserDTO user = new UserDTO();
            user.Status = "InActive";
            var result = _repository.DeleteUser(user);
            return Ok(result);
        }
    }
}

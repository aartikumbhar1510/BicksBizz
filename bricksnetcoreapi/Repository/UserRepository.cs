using bricksnetcoreapi.Models;
using bricksnetcoreapi.Models.dtos;
using Microsoft.IdentityModel.Tokens;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Text;

namespace bricksnetcoreapi.Repository
{
    public class UserRepository : IUserRepository
    {
        private  BricksBizBdContext _bricksBizBdContext;
        private IConfiguration _configuration;

        public UserRepository() 
        {
            
        }
    
        public bool AddUser(UserDTO user)
        {
            throw new NotImplementedException();
        }

        public bool DeleteUser(UserDTO user)
        {
            _bricksBizBdContext = new BricksBizBdContext();

            var result = _bricksBizBdContext.Users.Where(x => x.Email == user.Email).FirstOrDefault();
            if (result != null)
            {
                result.Status = user.Status;
                _bricksBizBdContext.SaveChanges();
                return true;

            }
                return false;

        }

        public string GenerateJwtToken(UserDTO user)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("lahukvishwanathumbhar"));
            var credentials = new SigningCredentials(securityKey,SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken("ABCDEFghijkLMNopqRStuVwZYX", "ABCDEFghijkLMNopqRStuVwZYX",
                null,expires:DateTime.Now.AddMinutes(120),
                signingCredentials:credentials);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }

        public UserDTO GetUser(string email)
        {
            _bricksBizBdContext = new BricksBizBdContext();
            
            var result = _bricksBizBdContext.Users.Where(x => x.Email == email).FirstOrDefault();

            if (result != null)
            {
                UserDTO user = new UserDTO()
                {
                    Email = result.Email,
                    Username = result.Username,
                    Userid = result.Userid,
                    Password = result.Password,
                    Status = result.Status
                };

                return user;
            }
            return new UserDTO();
            
        }

        public List<UserDTO> GetUsers()
        {
            _bricksBizBdContext = new BricksBizBdContext();
            
            List<UserDTO> userDTOs = new List<UserDTO>();
            foreach (var user in _bricksBizBdContext.Users)
            {
                UserDTO dTO = new UserDTO();
                dTO.Email = user.Email;
                dTO.Username=user.Username;
                dTO.Password = user.Password;
                dTO.Status = user.Status;
                userDTOs.Add(dTO);

            }
            return userDTOs;
        }

        public bool UpdateUser(UserDTO user)
        {
            throw new NotImplementedException();
        }

        public UserDTO ValidateUser(UserDTO user)
        {
            _bricksBizBdContext = new BricksBizBdContext();
            var result = _bricksBizBdContext.Users.Where(x=>x.Email == user.Email && x.Password == user.Password).FirstOrDefault();
            if (result != null)
            {
                UserDTO loggedInUser = new UserDTO();
                loggedInUser.Email = result.Email;
                loggedInUser.Username = result.Username;

                return loggedInUser;
            }
            return new UserDTO();
        }
    }
}

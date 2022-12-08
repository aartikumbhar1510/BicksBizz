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
        public BricksBizBdContext _bricksBizBdContext;
        private IConfiguration _configuration;

        public UserRepository(BricksBizBdContext bricksBizBdContext, IConfiguration configuration)
        {
            _bricksBizBdContext = bricksBizBdContext;
            _configuration = configuration;
        }
    
        public bool AddUser(UserModel user)
        {
            throw new NotImplementedException();
        }

        public bool DeleteUser(string email)
        {
            throw new NotImplementedException();
        }

        public string GenerateJwtToken(UserModel user)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]));
            var credentials = new SigningCredentials(securityKey,SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(_configuration["Jwt:Issuer"], _configuration["Jwt:Issuer"],
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
                    Password = result.Password
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
                userDTOs.Add(dTO);

            }
            return userDTOs;
        }

        public bool UpdateUser(UserModel user)
        {
            throw new NotImplementedException();
        }

        public UserDTO ValidateUser(UserModel user)
        {
            _bricksBizBdContext = new BricksBizBdContext();
            var result = _bricksBizBdContext.Users.Where(x=>x.Email == user.UserDTO.Email && x.Password == user.UserDTO.Password).FirstOrDefault();
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

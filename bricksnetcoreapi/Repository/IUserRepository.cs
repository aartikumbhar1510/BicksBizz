using bricksnetcoreapi.Models;
using bricksnetcoreapi.Models.dtos;

namespace bricksnetcoreapi.Repository
{
    public interface IUserRepository
    {
        List<UserDTO> GetUsers();
        bool AddUser(UserModel user);
        bool UpdateUser(UserModel user);
        UserDTO GetUser(string email);
        bool DeleteUser(string email);
        UserDTO ValidateUser (UserModel user);
        string GenerateJwtToken(UserModel user);
    }
}

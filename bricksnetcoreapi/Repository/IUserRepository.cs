using bricksnetcoreapi.Models;
using bricksnetcoreapi.Models.dtos;

namespace bricksnetcoreapi.Repository
{
    public interface IUserRepository
    {
        List<UserDTO> GetUsers();
        bool AddUser(UserDTO user);
        bool UpdateUser(UserDTO user);
        UserDTO GetUser(string email);
        bool DeleteUser(UserDTO user);
        UserDTO ValidateUser (UserDTO user);
        string GenerateJwtToken(UserDTO user);
    }
}

using bricksnetcoreapi.Models;
using bricksnetcoreapi.Models.dtos;

namespace bricksnetcoreapi.Repository
{
    public interface IUserRepository
    {
        List<UserDTO> GetUsers();
        bool AddUser(UserModel user);
        bool UpdateUser(UserModel user);
        UserModel GetUserById(int id);
        bool DeleteUser(int id);
        UserDTO ValidateUser (UserModel user);
        string GenerateJwtToken(UserModel user);
    }
}

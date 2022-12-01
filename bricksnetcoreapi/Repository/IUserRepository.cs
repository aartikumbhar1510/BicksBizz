using bricksnetcoreapi.Models;

namespace bricksnetcoreapi.Repository
{
    public interface IUserRepository
    {
        List<UserModel> GetUsers();
        bool AddUser(UserModel user);
        bool UpdateUser(UserModel user);
        UserModel GetUserById(int id);
        bool DeleteUser(int id);
        bool ValidateUser (UserModel user);
    }
}

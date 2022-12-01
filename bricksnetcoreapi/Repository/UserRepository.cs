using bricksnetcoreapi.Models;

namespace bricksnetcoreapi.Repository
{
    public class UserRepository : IUserRepository
    {
        public BricksBizBdContext _bricksBizBdContext;
        public bool AddUser(UserModel user)
        {
            throw new NotImplementedException();
        }

        public bool DeleteUser(int id)
        {
            throw new NotImplementedException();
        }

        public UserModel GetUserById(int id)
        {
            throw new NotImplementedException();
        }

        public List<UserModel> GetUsers()
        {
            throw new NotImplementedException();
        }

        public bool UpdateUser(UserModel user)
        {
            throw new NotImplementedException();
        }

        public bool ValidateUser(UserModel user)
        {
            _bricksBizBdContext = new BricksBizBdContext();
            var result = _bricksBizBdContext.Users.Where(x=>x.Email == user.UserDTO.Email && x.Password == user.UserDTO.Password).FirstOrDefault();
            if (result != null)
            {
                return true;
            }
            return false;
        }
    }
}

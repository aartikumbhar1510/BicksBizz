using bricksnetcoreapi.Models.dtos;

namespace bricksnetcoreapi.Models
{
    public class UserModel
    {
        public UserDTO  UserDTO { get; set; }
        public List<UserDTO> Users { get; set; }
    }
}

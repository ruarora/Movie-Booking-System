using API.Model;

namespace API.Services
{
    public class UserService : IUserService
    {
        public static List<User> UserList = new List<User>()
        {
            new User(){
                Name = "Admin",
                Email = "admin@admin.com",
                Password = "admin123" // can be hashed later on. 
            },
            new User(){
            Name = "User",
                Email = "user@user.com",
                Password = "user123" // can be hashed later on. 
            }
        };
        public bool Login(User userDetails)
        {
            return UserList.Exists(x => x.Email == userDetails.Email && x.Password == userDetails.Password);
        }

        public bool Register(User user)
        {
            var isUserExists = UserList.Exists(x => x.Email == user.Email);

            if (isUserExists)
            {
                return false;
            }

            UserList.Add(user);

            return true;
        }
    }
}

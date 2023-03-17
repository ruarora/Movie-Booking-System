using API.Model;

namespace API.Services
{
    public interface IUserService
    {
        public bool Login(User user);
        public bool Register(User user);
    }
}

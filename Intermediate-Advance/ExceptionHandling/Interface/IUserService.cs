using ExceptionHandling.models;

namespace ExceptionHandling.Interface
{
    public interface IUserService
    {
        User CreateUser(User user);
        User GetUser(string email);
    }
}

using ExceptionHandling.Interface;
using ExceptionHandling.models;
using System.Text.RegularExpressions;

namespace ExceptionHandling.Services
{
    public class UserService : IUserService
    {
        List<User> users = new List<User>(); // dummy database
        public User CreateUser(User user)
        {

            try
            {
                if (string.IsNullOrEmpty(user.Email))
                {
                    throw new ArgumentNullException($"{user.Email} can not be null or empty.");
                }
                if (!Regex.IsMatch(user.Email, "^[a-bA-B]+@+.[0-9]"))
                {
                    throw new ArgumentException($"{user.Email} is not a valid email");
                }
                if (string.IsNullOrEmpty(user.Name))
                {
                    throw new ArgumentNullException($"{user.Name} can not be null or empty.");
                }
                if (string.IsNullOrEmpty(user.Password) || user.Password.Length < 6)
                {
                    throw new ArgumentException($"{user.Password} must be at least 6 characters long.");
                }
                var newUser = new User
                {
                    Name = user.Name,
                    Email = user.Email,
                    Password = user.Password,
                };

                users.Add(newUser);

                return newUser;
            }
            catch (Exception ex)
            {
                throw new Exception($"{ex.Message}", ex);
            }
        }

        public User GetUser(string email)
        {
            throw new NotImplementedException();
        }
    }
}

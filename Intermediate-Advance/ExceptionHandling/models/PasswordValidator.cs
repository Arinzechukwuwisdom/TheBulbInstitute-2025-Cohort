using System.Text.RegularExpressions;

namespace ExceptionHandling.models
{
    public class PasswordValidator
    {
        public static bool IsValid(string password)
        {
            Regex regex = new Regex(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$");
            if (string.IsNullOrEmpty(password))
            {
                return false;
            }
            return regex.IsMatch(password);
        }
    }
}

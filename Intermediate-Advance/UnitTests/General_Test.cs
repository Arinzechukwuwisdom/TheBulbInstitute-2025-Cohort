using ExceptionHandling.models;

namespace UnitTests
{
    public class General_Test
    {
        [Fact] //it doesn't require any data or parameter... Non-parameterized test
        public void General_IsValidPassword()
        {
            //Arrange
            //var passwordValidator = new PasswordValidator();
            string password = "Password123!";

            //Act
            bool isValid = PasswordValidator.IsValid(password);
            //Assert
            Assert.True(isValid);
        }

        [Theory]
        [InlineData("Password123!", true)] //valid password
        [InlineData("password", false)] //no uppercase, no digit, no special character
        public void General_IsValidPassword_Theory(string password, bool expectedResult)
        {
            //Arrange
            //var passwordValidator = new PasswordValidator();
            //Act
            bool isValid = PasswordValidator.IsValid(password);
            //Assert
            Assert.Equal(expectedResult, isValid);
        }


    }
}

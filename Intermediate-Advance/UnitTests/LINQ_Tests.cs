using Collections;
using LINQ;

namespace UnitTests
{
    public class LINQ_Tests
    {
        [Fact]
        public void ReturnUser()
        {
            //Arrange
            var name = "foo";
            var name2 = "John Doe";
            var linqSynthax = new LinqSynthax();

            //Act
            var response = linqSynthax.ReturnUser(name);
            var response2 = linqSynthax.ReturnUser(name2);

            //Assert
            Assert.Null(response); // Expecting null since "foo" is not in the dictionary

            Assert.NotNull(response2); // Expecting a User object since "John Doe" is in the dictionary
            Assert.Equal(name2, response2.Name); // Check if the name matches
            Assert.Equal(30, response2.Age); // Check if the age matches
            Assert.True(response2.IsEmployed); // Check if the employment status is true
            Assert.Equal(50000.00, response2.Salary); // Check if the salary matches
        }
        public static User expectedUser = new User
        {
            Name = "John Doe",
            Age = 30,
            IsEmployed = true,
            Salary = 50000.00
        };
        [Theory]
        [InlineData("foo")] // Expecting null for "foo"
        [InlineData("John Doe")]
        [InlineData("Jane Smith")]
        public void ReturnUser_Theory(string name)
        {
            //Arrange
            var linqSynthax = new LinqSynthax();
            //Act
            var response = linqSynthax.ReturnUser(name);
            //Assert
            if (name == "foo")
            {
                Assert.Null(response); // Expecting null since "foo" is not in the dictionary
            }
            else if (name == "John Doe")
            {
                Assert.NotNull(response); // Expecting a User object since "John Doe" is in the dictionary
                Assert.Equal(expectedUser.Name, response.Name); // Check if the name matches
                Assert.Equal(expectedUser.Age, response.Age); // Check if the age matches
                Assert.True(response.IsEmployed); // Check if the employment status is true
                Assert.Equal(expectedUser.Salary, response.Salary); // Check if the salary matches
            }
            else
            {
                Assert.Null(response); // Expecting null for any other name not in the dictionary
            }
        }

        [Fact]
        public void PrintAllNames()
        {
            //Arrange
            var linqSynthax = new LinqSynthax();
            var expectedNames = new List<string> { "John ", "Janet", "Emma Taofeek", "Agba ", "Tinubu", "Collin" };
            //Act
            var response = linqSynthax.PrintAllNames();
            //Assert
            Assert.Equal(expectedNames, response); // Check if the returned list matches the expected names
            Assert.Collection(response,
                item => Assert.Equal("John ", item),
                item => Assert.Equal("Janet", item),
                item => Assert.Equal("Emma Taofeek", item),
                item => Assert.Equal("Agba ", item),
                item => Assert.Equal("Tinubu", item),
                item => Assert.Equal("Collin", item)
            ); // Check if the collection contains the expected items in order
            Assert.DoesNotContain("foo", response); // Ensure "foo" is not in the list
            Assert.Contains("John ", response); // Ensure "John " is in the list
            Assert.Equal(6, response.Count); // Ensure the count of the list is 6
        }

        [Fact]
        public void PrintNames()
        {
            var linqSynthax = new LinqSynthax();

            var response = linqSynthax.PrintNames();
            Assert.NotNull(response); // Ensure the response is not null
            Assert.IsType<Dictionary<int, User>>(response); // Ensure the response is of type List<string>
            Assert.Equal(2, response.Count); // Ensure the dictionary contains 8 items
            Assert.All(response, kvp =>
            {
                Assert.NotNull(kvp.Value); // Ensure each User object is not null
                Assert.NotEmpty(kvp.Value.Name); // Ensure the Name property is not empty
                                                 //Assert.InRange(kvp.Value.Age, 0, 120); // Ensure the Age property is within a reasonable range
                                                 //Assert.True(kvp.Value.IsEmployed || !kvp.Value.IsEmployed); // Ensure IsEmployed is a boolean value
                                                 //  Assert.InRange(kvp.Value.Salary, 0.0, double.MaxValue); // Ensure Salary is a non-negative value
            });
        }
    }
}

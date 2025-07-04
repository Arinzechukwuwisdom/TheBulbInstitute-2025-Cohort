
using TodoList.Models;
using TodoList.Repository;

namespace UnitTests
{
    public class TodoListTest
    {
        private readonly UserRepository userService = new UserRepository();

        [Theory]
        [InlineData("Tai", "Tai@gmail", 30)]
        [InlineData("Arinze", "Arinze@gmail", 30)]
        public async void User_CreateUser(string name, string email, int age)
        {
            var newUser = new User
            {
                Name = name,
                Email = email,
                Age = age
            };

            var result = await userService.Create(newUser);

            Assert.NotNull(result);
            Assert.Equal(201, result.StatusCode);
            Assert.True(result.IsSuccess);
            Assert.NotNull(result.Data);
            Assert.Equal(name, result.Data.Name);
            Assert.Equal(email, result.Data.Email);
            Assert.Equal(age, result.Data.Age);

            var userId = result.Data.Id;

            var isDeleted = await userService.Delete(userId);
            Assert.True(isDeleted);

            //var users = await userService.GetAll();
            //Assert.Empty(users);

            var userRes = await userService.GetById(userId);

            Assert.NotNull(userRes);
            Assert.False(userRes.IsSuccess);
            Assert.Equal(404, userRes.StatusCode);
            Assert.Null(userRes.Data);
        }

        [Fact]
        public async void User_GetAll()
        {
            var newUser1 = new User
            {
                Email = "test1@gmail.com",
                Name = "Test User",
                Age = 25
            };
            var newUser2 = new User
            {
                Email = "test2@gmail.com",
                Name = "Another User",
                Age = 30
            };

            var userCreateRes1 = await userService.Create(newUser1);

            Assert.NotNull(userCreateRes1);
            Assert.Equal(201, userCreateRes1.StatusCode);
            Assert.True(userCreateRes1.IsSuccess);
            Assert.NotNull(userCreateRes1.Data);
            Assert.Equal(newUser1.Name, userCreateRes1.Data.Name);
            Assert.Equal(newUser1.Email, userCreateRes1.Data.Email);

            var userCreateRes2 = await userService.Create(newUser2);
            Assert.NotNull(userCreateRes2);
            Assert.Equal(201, userCreateRes2.StatusCode);
            Assert.True(userCreateRes2.IsSuccess);
            Assert.NotNull(userCreateRes2.Data);
            Assert.Equal(newUser2.Name, userCreateRes2.Data.Name);
            Assert.Equal(newUser2.Email, userCreateRes2.Data.Email);

            var users = await userService.GetAll();
            Assert.NotNull(users);
            Assert.NotEmpty(users);
            Assert.Equal(2, users.Count);
            Assert.Collection(users,
                user => Assert.NotNull(user.Name),
                user => Assert.NotNull(user.Email)
                //user => Assert.InRange(user.Age, 18, 50)
            );

            var userId1 = userCreateRes1.Data.Id;
            var userId2 = userCreateRes2.Data.Id;

            var user1IsDeleted = await userService.Delete(userId1);
            Assert.True(user1IsDeleted);
            var user2IsDeleted = await userService.Delete(userId2);
            Assert.True(user2IsDeleted);

            var allUsersAfterDelete = await userService.GetAll();
            Assert.Empty(allUsersAfterDelete);
        }
    }
}

using Collections;

namespace LINQ
{
    public class LinqSynthax
    {
        List<User> users = new List<User>
        {
            new() { Name = "John Doe", Age = 30, IsEmployed = true, Salary = 50000.00 },
            new User { Name = "Jane Doe", Age = 28, IsEmployed = false, Salary = 45000.00 },
            new User { Name = "Emma Tai", Age = 25, IsEmployed = true, Salary = 60000.00 },

        };

        Dictionary<int, string> names = new Dictionary<int, string>
            {
                { 1, "John Doe" },
                { 2, "Jane Doe" },
                { 3, "Emma Tai" },
                {4, "Claud" },
                {5, "Claudia" },
                {6, "Claudius" },
                {7, "Arinze" },
                {8, "Fortunate" }
            };

        Dictionary<int, User> dictionaryOfUsers = new Dictionary<int, User>
            {
                { 1, new User { Name = "John Doe", Age = 30, IsEmployed = true, Salary = 50000.00 } },
                { 2, new User { Name = "Jane Doe", Age = 28, IsEmployed = false, Salary = 45000.00 } },
                { 3, new User { Name = "Emma Tai", Age = 25, IsEmployed = true, Salary = 60000.00 } },
                {4, new User { Name = "Claud", Age = 35, IsEmployed = false, Salary = 70000.00 } }
            };

        List<string> namesList = new List<string>
        {
            "John ",
            "Janet",
            "Emma Taofeek",
        };

        List<string> nameList2 = new List<string>
        {
            "Agba ",
            "Tinubu",
            "Collin",
        };
        public void PrintUsers()
        {
            //LINQ
            //LANGUAGE INTEGRATED QUERY

            //QUERY SYNTAX
            //METHOD SYNTAX

            //QUERY SYNTAX


            var user = new User
            {
                Name = "John Doe",
                Age = 30,
                IsEmployed = true,
                Salary = 50000.00
            };


            users.Add(user);
            users.Add(new User { Name = "Claud", Age = 35, IsEmployed = false, Salary = 70000.00 });



            // Query Syntax
            //var employedUsers = from usr in users
            //                    where usr.IsEmployed
            //                    select usr;

            // Method Syntax
            var employedUsers = users.Where(usr => usr.IsEmployed)
                                .Select(usr => new
                                {

                                    user.Name
                                });


            var ageBelow28 = users.Where(user => user.Age < 28);




            //Difference between All and Any
            // All checks if all elements in the collection satisfy a condition

            //var salaryAbove40k = users.All(user => user.Salary > 60000);
            //Console.WriteLine($"All users have a salary above 40k: {salaryAbove40k}");

            //// Any checks if any element in the collection satisfies a condition
            //var salaryBelow40k = users.Any(user => user.Salary > 40000);
            //Console.WriteLine($"Any user has a salary below 40k: {salaryBelow40k}");

            var userWithNameJohn = users.First(user => user.Name == "John Done");
            if (userWithNameJohn != null)
            {
                Console.WriteLine($"User found: {userWithNameJohn.Name}, Age: {userWithNameJohn.Age}, Employed: {userWithNameJohn.IsEmployed}");
            }
            else
            {
                Console.WriteLine("User not found.");
            }


            Console.WriteLine("\n-----------------------------------------------------------------------------------------\n");
            Console.WriteLine("List of Users:");
            foreach (var usr in employedUsers)
            {
                Console.WriteLine(usr);
            }

            Console.WriteLine("\nUsers with age below 28:");
            foreach (var usr in ageBelow28)
            {
                Console.WriteLine(usr);
            }
        }


        public User ReturnUser(string name)
        {
            var userWithNameJohn = users.FirstOrDefault(user => user.Name == name);
            // var userList = users.Where(user => user.IsEmployed).Contains(userWithNameJohn);
            if (userWithNameJohn == null)
            {
                return null;
            }
            return userWithNameJohn;

        }
        public string ReturnMatchingString(string input)
        {
            var matchingString = users.FirstOrDefault(user => user.Name.Equals(input));
            //var matchingString2 = users.FirstOrDefault(user => user.Name.Contains(input));
            if (matchingString != null)
            {
                return matchingString.Name;
            }
            return "No matching string found";
        }

        public Dictionary<int, User> PrintNames()
        {

            var users = dictionaryOfUsers.Where(u => u.Value.IsEmployed).ToDictionary();
            return users;
        }


        public List<string> PrintAllNames()
        {
            namesList.AddRange(nameList2);
            return namesList;
        }
    }
}

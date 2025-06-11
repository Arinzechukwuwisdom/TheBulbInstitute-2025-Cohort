using System.Collections;

namespace Collections
{
    public class CollectionTypes
    {
        //Collections are types in C# that allow you store, manage, and manipulate groups of related objects.

        // Two types of collections
        // 1. Generic Collections //
        // 2. Non-Generic Collections

        // Generic Collections are collections that can store any type of data, and they are type-safe.
        // Non-Generic Collections are collections that can store any type of data, but they are not type-safe.

        // non-generic collections
        public void NonGenericCollections()
        {
            // ArrayList
            // Hashtable
            // Stack
            // Queue
            // ArrayList is a non-generic collection that can store any type of data.
            // It is not type-safe, meaning you can add any type of data to it.
            // It is not recommended to use ArrayList in new code, use List<T> instead.
            // Hashtable is a non-generic collection that stores key-value pairs.
            // It is not type-safe, meaning you can add any type of data to it.
            // It is not recommended to use Hashtable in new code, use Dictionary<TKey, TValue> instead.
            // Stack is a non-generic collection that stores data in a last-in-first-out (LIFO) order.
            // It is not type-safe, meaning you can add any type of data to it.
            // It is not recommended to use Stack in new code, use Stack<T> instead.
            // Queue is a non-generic collection that stores data in a first-in-first-out (FIFO) order.
            // It is not type-safe, meaning you can add any type of data to it.
            // It is not recommended to use Queue in new code, use Queue<T> instead.

            // Example of ArrayList
            ArrayList arrayList = new ArrayList();
            arrayList.Add(1);
            arrayList.Add("Hello");
            arrayList.Add(3.14);
            arrayList.Add(true);

            //foreach (var item in arrayList)
            //{
            //    Console.WriteLine("Array List:");
            //    Console.WriteLine(item);
            //}

            var user = new User
            {
                Name = "Jane Doe",
                Age = 28,
                IsEmployed = false,
                Salary = 45000.00
            };
            // Example of Hashtable
            Hashtable userDetail = new Hashtable();
            //userDetail.Add("Name", "John Doe");
            //userDetail.Add("Age", 30);
            //userDetail.Add("IsEmployed", true);
            //userDetail.Add("Salary", 50000.00);
            userDetail.Add(user.Name, user);


            //foreach (DictionaryEntry entry in userDetail)
            //{
            //    Console.WriteLine("User Detail:");
            //    Console.WriteLine($"Key: {entry.Key}\nValue: {entry.Value}");
            //}

            //SortedList is a non-generic collection that stores key-value pairs in sorted order.
            // It is not type-safe, meaning you can add any type of data to it.
            SortedList sortedList = new SortedList();
            sortedList.Add("doe", "John Doe");
            sortedList.Add("emma", "Tai");
            sortedList.Add("claud", "Claudius");
            sortedList.Add("Arinze", "Arinze");
            //foreach (DictionaryEntry entry in sortedList)
            //{
            //    Console.WriteLine("Sorted List:");
            //    Console.WriteLine($"Key: {entry.Key}, Value: {entry.Value}");
            //}

            // Stack is a non-generic collection that stores data in a last-in-first-out (LIFO) order.
            Stack stack = new Stack();
            stack.Push(1);
            stack.Push("Hello");
            stack.Push(3.14);
            stack.Push(true);

            //Console.WriteLine("Stack:");
            //foreach (var item in stack)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine("\n----------------------------------------------------------\n");

            // Queue is a non-generic collection that stores data in a first-in-first-out (FIFO) order.
            Queue queue = new Queue();
            queue.Enqueue(1);
            queue.Enqueue("Hello");
            queue.Enqueue(3.14);
            queue.Enqueue(true);

            //Console.WriteLine("Queue:");
            //foreach (var item in queue)
            //{
            //    Console.WriteLine(item);
            //}
        }

        // Generic collections
        public void GenericCollections()
        {
            // List<T>
            // Dictionary<TKey, TValue>
            // HashSet<T>
            // SortedSet<T>
            // Stack<T>
            // Queue<T>



            // List<T> is a generic collection that can store any type of data.
            // It is type-safe, meaning you can only add data of the specified type to it.
            // It is recommended to use List<T> in new code.
            var user = new User
            {
                Name = "John Doe",
                Age = 30,
                IsEmployed = true,
                Salary = 50000.00
            };

            List<User> users = new List<User>
            {
                new User { Name = "John Doe", Age = 30, IsEmployed = true, Salary = 50000.00 },
                new User { Name = "Jane Doe", Age = 28, IsEmployed = false, Salary = 45000.00 },
                new User { Name = "Emma Tai", Age = 25, IsEmployed = true, Salary = 60000.00 },
                user,
            };
            users.Add(user);
            users.Add(new User { Name = "Claud", Age = 35, IsEmployed = true, Salary = 70000.00 });

            Console.WriteLine("List of Users:");
            foreach (var usr in users)
            {
                Console.WriteLine(usr);
            }
            Console.WriteLine("\n----------------------------------------------------------\n");
            // Dictionary<TKey, TValue> is a generic collection that stores key-value pairs.
            Dictionary<int, User> userDictionary = new Dictionary<int, User>
            {
                { 1, new User { Name = "John Doe", Age = 30, IsEmployed = true, Salary = 50000.00 } },
                { 2, new User { Name = "Jane Doe", Age = 28, IsEmployed = false, Salary = 45000.00 } },
                { 5, new User { Name = "Emma Tai", Age = 25, IsEmployed = true, Salary = 60000.00 } },
                { 4, new User { Name = "Claud", Age = 35, IsEmployed = true, Salary = 70000.00 } },
                {3, user}
            };
            userDictionary.Add(7, new User { Name = "Arinze", Age = 32, IsEmployed = true, Salary = 80000.00 });
            Console.WriteLine("Dictionary of Users:");
            foreach (var kvp in userDictionary)
            {
                Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
            }

            Dictionary<int, string> keyValuePairs = new()
            {
                { 1, "One" },
                { 2, "Two" },
                { 3, "Three" },
                { 4, "Four" }
            };

            Console.WriteLine("\n-----------------------------------------------------------\n");

            // HashSet<T> is a generic collection that stores unique elements.
            HashSet<string> keys = new HashSet<string>();
            keys.Add("doe");
            keys.Add("emma");
            keys.Add("claud");
            keys.Add("arinze");
            keys.Add("doe");
            keys.Add("john");
            keys.Add("john");
            Console.WriteLine("HashSet of Keys:");
            foreach (var key in keys)
            {
                Console.WriteLine(key);
            }

            Console.WriteLine("\n-----------------------------------------------------------\n");
            // SortedSet<T> is a generic collection that stores unique elements in sorted order.
            SortedSet<string> sortedKeys = new SortedSet<string>
            {
                "doe",
                "emma",
                "claud",
                "arinze",
                "john"
            };
            Console.WriteLine("SortedSet of Keys:");
            foreach (var key in sortedKeys)
            {
                Console.WriteLine(key);
            }

            Console.WriteLine("\n-----------------------------------------------------------\n");

            // SortedList<T> is a generic collection that stores key-value pairs in sorted order.
            SortedList<int, string> sortedList = new SortedList<int, string>
            {
                { 1, "One" },
                { 2, "Two" },
                { 3, "Three" },
                { 4, "Four" }
            };
            Console.WriteLine("SortedList of Key-Value Pairs:");
            foreach (var kvp in sortedList)
            {
                Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
            }

            Console.WriteLine("\n-----------------------------------------------------------\n");
            // Stack<T> is a generic collection that stores data in a last-in-first-out (LIFO) order.
            Stack<User> userStack = new Stack<User>();
            userStack.Push(new User { Name = "John Doe", Age = 30, IsEmployed = true, Salary = 50000.00 });
            userStack.Push(new User { Name = "Jane Doe", Age = 28, IsEmployed = false, Salary = 45000.00 });
            userStack.Push(new User { Name = "Emma Tai", Age = 25, IsEmployed = true, Salary = 60000.00 });
            userStack.Push(new User { Name = "Claud", Age = 35, IsEmployed = true, Salary = 70000.00 });

            Console.WriteLine("Stack of Users:");
            foreach (var usr in userStack)
            {
                Console.WriteLine(usr);
            }
            Console.WriteLine("\n-----------------------------------------------------------\n");
            // Queue<T> is a generic collection that stores data in a first-in-first-out (FIFO) order.
            Queue<User> userQueue = new Queue<User>();
            userQueue.Enqueue(new User { Name = "John Doe", Age = 30, IsEmployed = true, Salary = 50000.00 });
            userQueue.Enqueue(new User { Name = "Jane Doe", Age = 28, IsEmployed = false, Salary = 45000.00 });
            userQueue.Enqueue(new User { Name = "Emma Tai", Age = 25, IsEmployed = true, Salary = 60000.00 });
            userQueue.Enqueue(new User { Name = "Claud", Age = 35, IsEmployed = true, Salary = 70000.00 });
            Console.WriteLine("Queue of Users:");
            foreach (var usr in userQueue)
            {
                Console.WriteLine(usr);
            }
        }
    }

    public class User
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public bool IsEmployed { get; set; }
        public double Salary { get; set; }
        public override string ToString()
        {
            return $"Name: {Name}, Age: {Age}, IsEmployed: {IsEmployed}, Salary: {Salary}";
        }
    }
}

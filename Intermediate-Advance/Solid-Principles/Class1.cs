namespace Solid_Principles
{
    public class Class1
    {
        // Single Responsibility Principle (SRP)
        // A class should have only one reason to change, meaning that a class should only have one job or responsibility.
        // Open/Closed Principle (OCP)
        // Software entities (classes, modules, functions, etc.) should be open for extension but closed for modification.
        // This means that the behavior of a module can be extended without modifying its source code.

        // Liskov Substitution Principle (LSP)
        // Objects of a superclass should be replaceable with objects of a subclass without affecting the correctness of the program.

        Animal animal = new Dog
        {
            Name = "Buddy",
            Description = "A friendly dog"
        };
        Animal cat = new Cat
        {
            Name = "Whiskers",
            Description = "A playful cat"
        };

    }
    public class Animal
    {
        public string Name { get; set; }
        public string Description { get; set; }

    }
    public class Dog : Animal
    {
        public string Sound => "Woof";
    }
    public class Cat : Animal
    {
        public string Sound => "Meow";
    }

}

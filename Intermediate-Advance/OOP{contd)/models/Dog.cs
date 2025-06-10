using OOP_contd_.AbstractClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_contd_.models
{
    public class Dog : AnimalService
    {
        public override string Name { get; set; } = "Dog"; // Default name for the Dog class
        public override string Description { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override string Specie { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override void Eat()
        {
            throw new NotImplementedException();
        }
        public override void MakeSound()
        {
            Console.WriteLine("Wooof Woof Woof");
        }
    }
}

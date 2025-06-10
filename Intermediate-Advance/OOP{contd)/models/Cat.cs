using OOP_contd_.AbstractClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_contd_.models
{
    public class Cat : AnimalService
    {
        public override string Name { get; set; } = "Cat"; // Default name for the Cat class
        public override string Description { get;  set; } = "A small domesticated carnivorous mammal with soft fur, a short snout, and retractable claws."; // Default description for the Cat class
        public override string Specie { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override void Eat()
        {
            throw new NotImplementedException();
        }
   
    }
}

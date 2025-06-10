namespace OOP_contd_.AbstractClasses
{
    public abstract class AnimalService
    {
        public abstract string Name { get; set; }
        public abstract string Description { get; set; }
        public abstract string Specie { get; set; }
        public string Color { get; set; } = "Black";


        public virtual void MakeSound()
        {
            Console.WriteLine($"{Name} makes a sound.");

        }
        public virtual void MakeSound(string sound)
        {
            Console.WriteLine($"{Name} makes a sound: {sound}");
        }

        public abstract void Eat();
    }
}

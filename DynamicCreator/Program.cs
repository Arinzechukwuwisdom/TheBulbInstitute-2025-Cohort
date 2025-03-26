using System;

namespace DynamicCreator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome......");
            Console.WriteLine("Please select an option you would like to create");
            Console.WriteLine("1). House\n2). Account");

            var choice = Convert.ToInt16(Console.ReadLine());

            if(choice == 1)
            {
                Console.WriteLine("Select anything asides one or two");
            }

            else if(choice == 2)
            {
                Console.WriteLine("This is your account");
            }

            Console.Write("What type of house would you like e.g Bungalow or 2 bed or whatever:  ");
            var type = Console.ReadLine();

            Console.Write("How many plots woould you blah blah:  ");
            var plot = Convert.ToInt32(Console.ReadLine());

            Console.Write("How many rest rooms:  ");
            var numOfRestRooms = Convert.ToInt32(Console.ReadLine());

            var house = new House
            {
                _plot = plot,
                _numberOfToilets = numOfRestRooms,
                _typeOfHouse = type,
            };
            Console.WriteLine("You have successfully built a new house");
            
            Console.WriteLine(house.ReturnMessage());
        }
    }

    public class House 
    {
        //fields
        public string _typeOfHouse;
        public int _plot;
        public int _numberOfToilets;

        //Properties
        private string Type { get{ return _typeOfHouse; } set{_typeOfHouse = value; } }
        private int Plot { get {return _plot; } set {_plot = value; } }
        private int NumberOfToilets { get { return _numberOfToilets; } set {_numberOfToilets = value; } }


        public string ReturnMessage()
        {
            return $"Type: {Type}\nToilets: {NumberOfToilets}\nPlots: {Plot}";
        }

    }

    public class Account
    {
        public string AccountName { get; set; }
        public string AccountType { get; set; }
        public double Balance { get; set; }


    }
}

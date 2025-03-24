using System;
using System.Security.Cryptography.X509Certificates;

namespace Basics
{
    internal class Program
    {
        public string PhoneNumber { get; set; }
        static void Main(string[] args)
        {
            

            //Casing 
            //camel Casing and Pascal Casing


            int bal = (int)13.4;
            short bal2 = (short)20.25;
            

            string text = "Adesina is a great man";

            //bool num = false;

            int dogName = Convert.ToInt32("Biily");
            Console.WriteLine(dogName);

            int chasisNumber = -999999999; //both negative and postive whole numbers 
            uint num = 12; // positive whole numbers

            //Console.WriteLine(dogName);

            //Car toyota = new Car(); // Creating an object or an instance of the car class


            //toyota.Brand = "Toyota";
            //toyota.NumberOfCylinders = 1;
            //toyota.Name = "Highlander";

            Car mercedes = new Car
            {
                Brand = "Mercedes",
                Name = "S Class",
                NumberOfCylinders = 12
            };
        }
    }
    //Access modifiers define the access level of a property, class, method etc.
    //public allows for access through out the application
    //private allows for access only in the defination class
    //internal allows for access within the project
    //Classes
    public class Car
    {
        public string Name { get; set; }
        public string Brand { get; set; }
        public int NumberOfCylinders { get; set; } 


        //Variables is storage or container that holds a value
        //Data types is just like the gender of the class, property or whatever


        //1byte = 8 bits
        //integers hold signed whole numbers/ 32 bits or 4 bytes
        const int chasisNumber = -999999999; //both negative and postive whole numbers 
        uint num = 12; // positive whole numbers

        

       
        // Shorts are the 16bits datatypes that hold whole numbers / 16bits or 2 bytes
        short short1 = 11012; // positive and negative whole numbers
        ushort uShort = 100;

        //Long: Is the largest datatype for holding whole numbers / 64bits or 8 bytes
        long long1 = -1227384849394939481;
        ulong long2 = 1273847384938432323;

        //Byte is the smallest that holds 8bits or 1byte
        byte byte1 = 255;




        //string //char
        string name = "Fortunate";
        char char1 = 'F';

        // For decimal values
        // float, decimal, double

        float accountBal = 12.12F;
        decimal accBal = 13.59M;
        double accBalance = 10.32;

        //Boolean
        bool isSheABoy = false;
        bool doYouHaveMoney = true;
        


        //Public, Internal, Private, Protected

    }
}

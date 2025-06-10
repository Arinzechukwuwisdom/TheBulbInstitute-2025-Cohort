using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Typecasting
    {
        public static void Cast()
        {
            //explicit casting
            double num = 1.37; //1.32
            int num2 = (int)num; //1

            long val = 263;
            int newVal = (int)val;

            short newVal2 = (short)newVal;
            //Console.WriteLine($"num={num}\n\nnum2={num2}");//

            //implicit
            char c = 'Z';
            int cee = c;
            
            Console.WriteLine(cee);

            //int val = 10;
            //double val2 = val;

        }

        public static void Boxing()
        {
            //Boxing is converting a value type into a reference type
            //unboxing Converting a reference type into a value type..

            //
            int num = 16;
            object obj = num;

            Console.WriteLine(obj);
            object obj2 = obj;
            obj2 = 20;

            Console.WriteLine(obj);
            Console.WriteLine(obj2);

            bool val = false;
            object newOb = val;

            bool newVal = (bool)newOb;
           
        }

        public void ConditionalStatements(string race)
        {
            //if, else, else if
            if (race is "black")
            {
                Console.WriteLine("Ma nigga");
            }
            else if(race is not "black")
            {
                Console.WriteLine("Welcome");
            }
            else 
            {

            }

            //switch cases

            switch (race)
            {
                case "black":
                Console.WriteLine("Ma nigga");
                break;
                case "white":
                Console.WriteLine("White boy");
                break;
                default:
                Console.WriteLine("which one you comee be");
                break;
            }
        }

        /// <summary>
        /// This method checks if the value of age is above 18
        /// </summary>
        /// <param name="age"></param>
        /// <returns></returns>
        public string CheckAge(int age)
        {
            bool above18 = age >= 18; // true or false

            string response = "";
            //bool below18 = age < 18;

            switch (above18)
            {
                case true:
                response = "You can drink here";
                break;
                case false:
                response = "Go and buy Bobo";
                break;
            }

            return response;
        }

        public static string ResponseManager()
        {
            Console.WriteLine("We are here");
            Console.WriteLine("We are here");
            Console.WriteLine("We are here");
            Console.WriteLine("We are here");
            return "We are here";
            Console.WriteLine("We are not here");
            Console.WriteLine("We are  not here");
        }
    }


}

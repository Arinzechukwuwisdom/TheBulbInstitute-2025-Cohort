using System;

namespace Methods_Constructors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            //Program2 program = new Program2();
            var response = Program2.IntroText();
            Console.WriteLine($"Your name is:{response}");

        }

        
        //Methods: are blocks of codes that do something...or performs a task.


    }

    public  class Program2 
    {
        public static string _prop;

        public static string IntroText()
        {
            Console.Write("Please enter your name:");
            var userName = Console.ReadLine();
            return userName;
        }
        public static void PrintText()
        {
            Console.WriteLine("This is our first method");
        }

        public string ReturnText()
        { 
            string response = "This is our second method";
            return response;
        }

        public bool IsLegit(int age1, int age2)
        {
            return age1 > age2;
        }

        public int Num(int num1, int num2)
        {
            return num1 + num2;
        }


    }

}

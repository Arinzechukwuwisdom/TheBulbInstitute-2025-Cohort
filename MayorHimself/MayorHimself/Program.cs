using System;

namespace MayorHimself
{
    public class Calculator
    {
        public int Addition(int num1, int num2)
        {
            return num1 + num2;
        }
        public int Subtract(int num1, int num2)
        {
            return num1 - num2;
        }

        public int Divide(int num1, int num2)

        {
            return num1 / num2;

        }

        public int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }


        static void Main()
        {
            Console.WriteLine("====Simple Calculator====");
            Console.WriteLine("Enter first Number");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second Number");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("1/2/3/4 for Add/Subtract/Divide/Multiply");

        }

    }

}

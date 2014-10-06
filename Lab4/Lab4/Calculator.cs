using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    public class Calculator
    {
        //Constructor
        public Calculator()
        {

        }
        public static string getNumberOne()
        {
            
            Console.WriteLine("Please enter your first number");
            string one = Console.ReadLine();

            return one;
        }

        public static string getNumberTwo()
        {

            Console.WriteLine("Thank you, Please enter your second number");
            string two = Console.ReadLine();

            return two;
        }

        public static double Divide(double a, double b)
        {
            double num = 0;
            try
            {                
                    num = a / b;               
            }
            catch (DivideByZeroException d)
            {
                d.ToString();
                Console.WriteLine("Unable to divide by zero");
                
            }
            
            return num;
        }

    }
}

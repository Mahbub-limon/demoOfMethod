using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace demoOfMethod
{
    internal class Program
    {
        public static void Message( string text)
        {
            Console.WriteLine(text);
        }
        public static void Add(int num1,int num2) {
                      
            int result=num1 + num2;
            Console.WriteLine($"{num1}+{num2}= {result}");
        }

        public static void Subtraction(int num1,int num2)
        {
            int result=num1 - num2;
            Console.WriteLine($"{num1}-{num2}={result}");
        }
        public static void Multiplication(int num1, int num2) 
        { 
         int result =num1 * num2;
         Console.WriteLine($"{num1}*{num2}={result}");

        }
        public static void Divide(int num1, int num2)
        {
            int result = num1 / num2;
            Console.WriteLine($"{num1}/{num2}={result}");
        }



        static void Main(string[] args)
        {

            Message("Welcome in the Calculator");
            
            Add(2, 3);
            Subtraction(2, 3);
            Multiplication(2, 3);
            Divide(2, 3);

            Message("Thank you");

        }
    }
}

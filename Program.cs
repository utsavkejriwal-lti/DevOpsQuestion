using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        public static int Multiply(int a, int b)
        {
            return a * b;
        }

        public static int Addition(int a, int b)
        {
            return a + b;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number");
            int num1 = 0;
            while(!Int32.TryParse(Console.ReadLine(),out num1) || num1 == 0)
            {
                Console.WriteLine("Number invalid or zero");
            }


            Console.WriteLine("Enter second number");
            int num2 = 0;
            while (!Int32.TryParse(Console.ReadLine(), out num2) || num2 == 0)
            {
                Console.WriteLine("Number invalid or zero");
            }
            

            
            Console.WriteLine("Product:" + Multiply(num1,num2));
            Console.WriteLine("Addition:" + Addition(num1,num2));

            Console.ReadKey();
        }
    }
}

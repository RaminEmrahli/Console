using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace recursion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n=int.Parse(Console.ReadLine());
            while (n >= 0)
            {
                
                Console.WriteLine(factorial(n));
                n = int.Parse(Console.ReadLine());
            } 
            Console.ReadKey();
        }
        static int factorial(int n)
        {
            int result = 0;
            if (n > 1)
            {
                
                result = n;
                n = n - 1;
                result = result * factorial(n);
            }
            else
            {
                result = 1;
            }
            return result;
        }
    }
}

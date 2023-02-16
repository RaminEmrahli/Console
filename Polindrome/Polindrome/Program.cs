using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int a = 0;
            Console.Write("Enter the number:");
            int n = int.Parse(Console.ReadLine());
             int c = n;

            while (n > 0)
            {
                a = n % 10;
                sum = (sum * 10) + a;
                n = n / 10;
            }
            if (c==sum)
            {
                Console.Write("Number is Polindrome");
            }
            else
            {
                Console.Write("Number is not Polindrome");
            }
            Console.ReadKey();
        }
    }
}
    


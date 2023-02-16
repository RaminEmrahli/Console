using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enums
{
    internal class Program
    {
        enum Days
        {
            Monday=1,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }

        static void Main(string[] args)
        {
            Console.Write("Enter number of day :");
            int number = int.Parse(Console.ReadLine());

            if (number >= 1 && number <= 7)
            {
                if(number == (int)Days.Monday)
                {
                    Console.WriteLine("The day of week according to the number :"+Days.Monday);
                }
                if (number == (int)Days.Tuesday)
                {
                    Console.WriteLine("The day of week according to the number :" + Days.Tuesday);
                }
                if (number == (int)Days.Wednesday)
                {
                    Console.WriteLine("The day of week according to the number :" + Days.Wednesday);
                }
                if (number == (int)Days.Thursday)
                {
                    Console.WriteLine("The day of week according to the number :" + Days.Thursday);
                }
                if (number == (int)Days.Friday)
                {
                    Console.WriteLine("The day of week according to the number :" + Days.Friday);
                }
                if (number == (int)Days.Saturday)
                {
                    Console.WriteLine("The day of week according to the number :" + Days.Saturday);
                }
                if (number == (int)Days.Sunday)
                {
                    Console.WriteLine("The day of week according to the number :" + Days.Sunday);
                }
            }
            else
            {
                Console.WriteLine("Wasn't Found");
            }
            Console.ReadKey();
        }
    }
}

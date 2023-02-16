using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            characters();
            Console.ReadKey();
        }
        static void characters()
        {
            char[] array = new char[80] { '1', '2', '3', ' ', 'H', 'e', 'l', 'l', 'o', ' ', 'W', 'o', 'r', 'l', 'd', '2', '0', '0', '4', ' ', 'W', 'e', 'l', 'c', 'o', 'm', 'e', ' ', 't', 'o', ' ', 'C', '#', ' ', 'p', 'r', 'o', 'g', 'r', 'a', 'm', 'm', 'i', 'n', 'g', '0', '0', '0', '4', '5', '6', '7', '8', '9', ' ', '1', '0', ' ', '1', '1', ' ', '1', '2', ' ', '1', '3', ' ', '1', '4', ' ', '1', '5', ' ', '1', '6', ' ', '1', '7', ' ', '.' };

            for(int i = 0; i < array.Length; i++)
            {
                if(array[i] >=48 && array[i] <= 57)
                {
                    Console.Write(array[i]);
                }
            }

            Console.WriteLine();


            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] >= 0 && array[i] < 48 || array[i] > 57 && array[i] < 127)
                {
                    Console.Write(array[i]);
                }
            }
        }
    }
}

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
            char[] array = new char[70];
            Console.WriteLine("Enter elements of array:");
            int index = 0;

            for(int i = 0; true; i++)
            {
                array[i] = (char)Console.Read(); 
                if(array[i] == '.')
                {
                    index = i;
                    break;
                }
            }

            for(int i = index-1; i >=0; i--)
            {
                Console.Write(array[i]);
            }
        }
    }
}

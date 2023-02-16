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
            int k = 0;
            char[] array = new char[80];
            Console.WriteLine("Enter elements of array:");
            int index = 0;

            for (int i = 0; true; i++)
            {
                array[i] = (char)Console.Read();
                if (array[i] == '.')
                {
                    index = i;
                    break;
                }
                if (array[i] == ' ')
                {
                    index = i;
                    for (int j = 0; i < index / 2; j++)
                    {
                        if (array[j] == array[index - j - 1])
                        {
                            k++;
                        }
                    }
                }
                if (k != index / 2)
                {
                    break;
                }
                else
                {
                    k = 0;
                }
            }

            for (int i = 0; i < index / 2; i++)
            {
                if (array[i] == array[index - i - 1])
                {
                    k++;
                }
            }
            if (k == index / 2)
            {
                Console.WriteLine("simmetrik");
            }
            else
            {
                Console.WriteLine("simmetrik deyil");
            }
        }
    }
}

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
            char firstelement = '0';
            int index = 0;
            int indexOfRepetitive = 0;
            int numberOfRepetitive = 0;
            int alternativeNumber = 0;
            for (int i = 0; true; i++)
            {
                array[i] = (char)Console.Read();
                if (array[i] == '.')
                {
                    index = i;
                    break;
                }
            }

            for (int i = index - 1; i >= 0; i--)
            {
                Console.Write(array[i]);
            }

            Console.WriteLine();

            for (int i = 0; i <index; i++)
            {
                if(array[i] == firstelement)
                {
                    numberOfRepetitive++;
                    if(numberOfRepetitive >= 2)
                    {
                        indexOfRepetitive = i;
                    }
                }
                else
                { 
                    if (numberOfRepetitive > alternativeNumber)
                    {
                        alternativeNumber = numberOfRepetitive;
                    }
                    firstelement = array[i];
                    numberOfRepetitive = 1;
                }
            }
            if (numberOfRepetitive > alternativeNumber)
            {
                alternativeNumber = numberOfRepetitive;
            }
            Console.Write(alternativeNumber+"dene ");
            Console.Write(array[indexOfRepetitive]);
        }
    }
}

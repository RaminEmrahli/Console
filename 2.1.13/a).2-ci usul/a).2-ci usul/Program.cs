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
        #region methods
        static void characters()
        {
            char[] array;
            int index, numberOfRepetition, alternative;
            char repetiton;
            input(out array, out index, out numberOfRepetition, out alternative, out repetiton);

            index = reverseSequence(array);
            repetitonElement(array, index, ref numberOfRepetition, ref alternative, ref repetiton);
        }

        private static void repetitonElement(char[] array, int index, ref int numberOfRepetition, ref int alternative, ref char repetiton)
        {
            for (int i = 0; i < index; i++)
            {
                for (int j = i + 1; j < index; j++)
                {
                    if (array[i] == array[j] && array[j] != char.MaxValue)
                    {
                        array[j] = char.MaxValue;
                        numberOfRepetition++;
                    }
                }
                if (numberOfRepetition + 1 > alternative)
                {
                    repetiton = array[i];
                    alternative = numberOfRepetition + 1;
                    numberOfRepetition = 0;
                }
            }
            if (numberOfRepetition + 1 == alternative)
            {
                Console.WriteLine("There are an equal number of repetitions");
            }
            else
            {
                Console.Write("Repetitive element:");
                Console.Write(alternative + " pieces " + repetiton);
            }
        }

        private static int reverseSequence(char[] array)
        {
            int index;
            for (int i = 0; true; i++)
            {
                array[i] = (char)Console.Read();
                if (array[i] == '.')
                {
                    index = i;
                    break;
                }
            }
            Console.Write("Reverse sequence:");
            for (int i = index - 1; i >= 0; i--)
            {
                Console.Write(array[i]);
            }

            Console.WriteLine();
            return index;
        }

        private static void input(out char[] array, out int index, out int numberOfRepetition, out int alternative, out char repetiton)
        {
            array = new char[70];
            Console.WriteLine("Enter elements of array:");
            index = 0;
            numberOfRepetition = 0;
            alternative = 0;
            repetiton = 'a';
        }
    }
}
#endregion
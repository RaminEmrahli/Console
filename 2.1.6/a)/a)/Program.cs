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
            deleteTheGivenNumber();
            Console.ReadKey();
        }
        #region
        static void deleteTheGivenNumber()
        {
            Console.Write("Enter length:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the numbers:");
            double[] array = new double[n];
            int i;

            for (i = 0; i < n; i++)
            {
                array[i] = double.Parse(Console.ReadLine());
            }

            Console.Write("Old array:");

            for (i = 0; i < n; i++)
            {
                Console.Write(array[i] + " ");
            }

            Console.WriteLine();
            Console.WriteLine("Enter the numbers you want to delete:");
            while (true)
            {
                string astr = Console.ReadLine();
                if (astr == string.Empty)
                {
                    break;
                }
                else
                {
                    double a = double.Parse(astr);
                    for (i = 0; i < n; i++)
                    {
                        if (a == array[i])
                        {
                            array[i] = double.MinValue;
                        }
                    }
                }
            }

                Console.Write("New Array: ");

                for (i = 0; i < n; i++)
                {
                    if (array[i] != double.MinValue)
                    {
                        Console.Write(array[i] + " ");
                    }
                }
            }
        }
    }
#endregion
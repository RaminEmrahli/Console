using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace v_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            negativesAndPozitives();
            Console.ReadKey();
        }
        #region method
        static void negativesAndPozitives()
        {
            Console.Write("Enter length:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter elements of array:");
            double[] array = new double[n];
            double[] newarray = new double[n];
            int i;
            int j=0;
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

            for (i = 0; i < n; i++)
            {
                if (array[i] < 0)
                {
                    while(j < n)
                    {
                        newarray[j]=array[i];
                        break;
                    }
                    j++;
                }
            }

            for (i = 0; i < n; i++)
            {
                if (array[i] > 0)
                {
                    while (j < n)
                    {
                        newarray[j] = array[i];
                        break;
                    }
                    j++;
                }
            }

            Console.Write("New Array: ");
         
                for (j = 0; j < n; j++)
                {
                  Console.Write(newarray[j] + " ");
                }
            }
        }
    }
#endregion
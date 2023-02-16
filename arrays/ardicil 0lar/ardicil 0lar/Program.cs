using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ardicil_0lar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            array();
            Console.ReadKey();
        }
        #region methods
        static void array()
        {
            Console.Write("Eded sayini daxil edin:");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            Console.WriteLine("Ededleri daxil edin:");
            int i;
            int sifirsayi = 0;
            int alternativ = 0;
            for (i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("Ededler:");
            Console.WriteLine();
            for (i = 0; i < n; i++)
            {
                Console.Write(array[i]);
                Console.Write(" ");
            }
            Console.WriteLine();
            for (i = 0; i < n; i++)
            {
                if (array[i] == 0)
                {
                    sifirsayi++;
                }
                else
                {
                    if (sifirsayi > alternativ)
                    {
                        alternativ = sifirsayi;
                    }
                    sifirsayi = 0;
                }
            }
            if (sifirsayi > alternativ)
            {
                alternativ = sifirsayi;
            }
            if (alternativ == 0)
            {
                Console.Write("Sifir tapilmadi");
            }
            else
            {
                Console.Write($"Ardicil gelen en cox sifir={alternativ}");
            }
        }
#endregion
    }
}

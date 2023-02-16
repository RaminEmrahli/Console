using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Simvollari daxil edin:");
            int countkey = 0;
            int k = 0;
            int e = 0;
            int y = 0;
            while (true)
            {
                char ch = (char)Console.Read();
                if (ch == '.')
                {
                    break;
                }
                if (ch == 'k' && k == 0)
                {
                    k++;
                }
                if (ch == 'e')
                {
                    e++;
                    if (ch == 'e' && k == 1)
                    {
                        k++;
                    }
                }
                if (ch == 'y')
                {
                    y++;
                    if (ch == 'y' && k == 2)
                    {
                        k++;
                    }
                }
                else if (ch != 'k' && ch != 'e' && ch != 'y')
                {
                    k = 0;
                }
                if (k == 3 && e == 1 && y == 1)
                {
                    countkey++;
                    k = 0;
                    e = 0;
                    y = 0;
                }
                else if (k != 3 && e == 1 && y == 1 || k==0 && e>=1 || k==0 && y>=1)
                {
                    k = 0;
                    e = 0;
                    y = 0;
                }


            }
            Console.Write($"countkey={countkey}");
            Console.ReadKey();
        }
    }
}

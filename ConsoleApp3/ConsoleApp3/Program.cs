using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n+1];
            for(int i = 0; i < array.Length; i++)
            {
                array[i] = Fibonacci(i);
            }
            List<int> list = new List<int>();
            for(int i = 0; i < array.Length; i++)
            {
                if(array[i] >= 10)
                {
                    list.Add(array[i]/10);
                    list.Add(array[i]%10);
                }
                else
                {
                    list.Add(array[i]);
                }
            }
            int[] newArray=list.ToArray();
            Console.WriteLine(newArray[n]);
            Console.ReadKey();
        }
        static int Fibonacci(int n)
        {
            if(n == 0 || n == 1)
            {
                return n;
            }
            else
            {
                return Fibonacci(n - 1) + Fibonacci(n - 2);
            }
        }
    }
}

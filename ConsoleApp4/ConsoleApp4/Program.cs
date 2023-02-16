using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string a = DateTime.Now.ToString("D");
            Console.WriteLine(a.Remove(3,2));
            Console.ReadLine();
        }
        
    }
}

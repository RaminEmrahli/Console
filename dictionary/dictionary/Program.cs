using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> personInfo = new Dictionary<string, int>();
            personInfo.Add("Ruslan", 18);
            personInfo.Add("Bilal", 22);
            personInfo.Add("Hesen", 15);
            NewMethod(personInfo);
            int count = personInfo.Count();
            Console.WriteLine();
            Console.WriteLine("Istifadeci sayi : " + count);
            Console.WriteLine();
            personInfo.Remove("Bilal");
            NewMethod(personInfo);
            Console.ReadLine();
        }

        static void NewMethod(Dictionary<string, int> personInfo)
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(personInfo["Bilal"]);
            }
        }
    }
}
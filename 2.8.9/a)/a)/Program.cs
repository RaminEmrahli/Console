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
            List<double> myList = InputList();
            OutputList(myList);
            RandomList(myList);
            OutputList(myList);
            SumOfListElements(myList);
            Console.ReadKey();
        }
        #region methods
        static List<double> InputList()
        {
            Console.Write("Enter length of list :");
            int length = int.Parse(Console.ReadLine());
            List<double> myList = new List<double>(length);
            Console.WriteLine("Enter elements of list :");
            for (int i = 0; i < length; i++)
            {
                myList.Add(double.Parse(Console.ReadLine()));
            }
            myList.Sort();
            Console.WriteLine("The given list :");
            return myList;
        }
        static List<double> RandomList(List<double> myList)
        {
            Random random = new Random();
            for (int i = 0; i < 25; i++)
            {
                myList.Add(random.Next(100));
            }
            myList.Sort();
            Console.WriteLine("The generated list :");
            return myList;
        }
        static void SumOfListElements(List<double> myList)
        {
            double sum = 0;
            double average = 0;
            for (int i = 0; i < myList.Count; i++)
            {
                sum += myList[i];
            }
            average = sum/myList.Count;
            Console.WriteLine($"sum ={sum}");
            Console.WriteLine($"average ={average}");
        }
        static void OutputList(List<double> myList)
        {
            for (int i = 0; i < myList.Count; i++)
            {
                Console.Write(myList[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
#endregion
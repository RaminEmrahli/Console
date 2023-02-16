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
            RemoveElementFromList(myList);
            OutputList(myList);
            Console.ReadKey();
        }
        static List<double> InputList()
        {
            Console.Write("Enter length of list1 :");
            int length = int.Parse(Console.ReadLine());
            List<double> myList = new List<double>(length);
            Console.WriteLine("Enter elements of list :");
            for (int i = 0; i < length; i++)
            {
                myList.Add(double.Parse(Console.ReadLine()));
            }
            Console.WriteLine("The given list :");
            return myList;
        }
        static List<double> RemoveElementFromList(List<double> myList)
        {
            if(myList.Count == 1)
            {
                myList.RemoveAt(0);
            }
            else if(myList.Count >= 2)
            {
                myList.RemoveRange(0, 2);
            }
            Console.WriteLine("Enter element want to delete :");
            int delete = int.Parse(Console.ReadLine());
            myList.RemoveAll(tel => tel == delete);
            Console.WriteLine("The generated list :");
            return myList;
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

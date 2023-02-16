using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<double> myList1;
            List<double> myList2;
            InputList(out myList1,out myList2);
            List<double> positiveList = CreatePositiveList(myList1,myList2);
            List<double> negativeList = CreateNegativeList(myList1,myList2);
            OutputList(positiveList, negativeList);
            Console.ReadKey();
        }
        #region methods
        static void InputList(out List<double> myList1, out List<double> myList2)
        {
            Console.Write("Enter length of list1 :");
            int length = int.Parse(Console.ReadLine());
            myList1 = new List<double>(length);
            Console.WriteLine("Enter elements of list :");
            for(int i = 0; i < length; i++)
            {
                myList1.Add(double.Parse(Console.ReadLine()));
            }

            Console.Write("Enter length of list2 :");
            int length1 = int.Parse(Console.ReadLine());
            myList2 = new List<double>(length);
            Console.WriteLine("Enter elements of list :");
            for (int i = 0; i < length1; i++)
            {
                myList2.Add(double.Parse(Console.ReadLine()));
            }
        }
        static List<double> CreatePositiveList(List<double> myList1,List<double> myList2)
        {
            List<double> positiveList = new List<double>();
            for(int i = 0; i < myList1.Count; i++)
            {
                if(myList1[i] > 0)
                {
                    positiveList.Add(myList1[i]);
                }
            }
            for(int i = 0; i < myList2.Count; i++)
            {
                if (myList2[i] > 0)
                {
                    positiveList.Add(myList2[i]);
                }
            }
            return positiveList;
        }
        static List<double> CreateNegativeList(List<double> myList1,List<double> myList2)
        {
            List<double> negativeList = new List<double>();
            for (int i = 0; i < myList1.Count; i++)
            {
                if (myList1[i] < 0)
                {
                    negativeList.Add(myList1[i]);
                }
            }
            for (int i = 0; i < myList2.Count; i++)
            {
                if (myList2[i] < 0)
                {
                    negativeList.Add(myList2[i]);
                }
            }
            return negativeList;
        }
        static void OutputList(List<double> positiveList,List<double> negativeList)
        {
            Console.WriteLine("Positive List :");
            for(int i = 0; i < positiveList.Count; i++)
            {
                Console.Write(positiveList[i]+" ");
            }
            Console.WriteLine();
            Console.WriteLine("Negative List :");
            for (int i = 0; i < negativeList.Count; i++)
            {
                Console.Write(negativeList[i]+" ");
            }
        }
        #endregion
    }
}

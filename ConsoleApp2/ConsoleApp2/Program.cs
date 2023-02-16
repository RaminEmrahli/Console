using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class ListElement<T>
    {
        public int data;
        public ListElement<T> next;
        public ListElement<T> previous;
    };

    class LinkedList<T>
    {
        private int Capacity = 0;
        public ListElement<T> head;
        public LinkedList()
        {
            head = null;
        }
        public void AddFirst(int data)
        {
            ListElement<T> listElement = new ListElement<T>();
            listElement.data = data;
            listElement.next = null;
            listElement.previous = null;
            if (head == null)
            {
                head = listElement;
                Capacity++;
            }
            else
            {
                head.previous = listElement;
                listElement.next = head;
                head = listElement;
                Capacity++;
            }
        }
        public void AddLast(int data)
        {
            ListElement<T> listElement = new ListElement<T>();
            listElement.data = data;
            listElement.next = null;
            listElement.previous = null;
            if (head == null)
            {
                head = listElement;
                Capacity++;
            }
            else
            {
                ListElement<T> temp = new ListElement<T>();
                temp = head;
                while (head.next != null)
                {
                    head = head.next;
                }
                head.next = listElement;
                listElement.previous = head;
                head = temp;
                Capacity++;
            }
            
        }
        public void PrintList()
        {
            ListElement<T> temp = new ListElement<T>();
            temp = head;
            if (head == null)
            {
                Console.WriteLine("List is empty :");
            }
            else
            {
                Console.Write("List : ");
                while (head != null)
                {
                    Console.Write(head.data + " ");
                    head = head.next;
                }
            }
            head = temp;
        }
        public int Count()
        {
            Console.WriteLine();
            return Capacity;
        }
        public void Remove(int number)
        {
            if (head == null)
            {
                Console.WriteLine("List is empty :");
            }
            else
            {
                int countOfDeletions = 0;
                ListElement<T> temp = new ListElement<T>();
                while (head != null)
                {
                    if (head.data == number)
                    {
                        temp = head;
                        head = null;
                        head = temp;
                        countOfDeletions++;
                    }
                    if (countOfDeletions == 1)
                    {
                        break;
                    }
                    head = head.next;
                }
            }
        }
        public void RemoveFirst()
        {
            if (head != null)
            {
                head = head.next;
                Capacity--;
            }
        }
        public void RemoveLast()
        {
            //if (head != null)
            //{
            //    int count = Count();
            //    ListElement<T> temp1 = new ListElement<T>();
            //    ListElement<T> temp2 = new ListElement<T>();
            //    temp1 = head;
            //    temp2 = temp1;
            //    while(temp1.next != null)
            //    {
            //        temp2 = temp1;
            //        temp1 = temp1.next;
            //    }
            //    temp2.next = null;
            //    Capacity--;
            //}
        }
    };

    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> list = new LinkedList<int>();
            list.AddFirst(1);
            list.AddLast(2);
            list.AddFirst(3);
            list.AddLast(4);
            list.AddFirst(5);
            LinkedList<int> list1;
            Console.WriteLine(list.Count());
            Console.ReadKey();
        }
    }
}
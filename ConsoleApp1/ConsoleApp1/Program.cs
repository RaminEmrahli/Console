using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class ListElement<T>
    {
        public T data;
        
        public ListElement<T> nextElement;
        public ListElement(T el)
        {
            this.data = el;
        }
}
    class MyList<T>
    {
        public ListElement<T>[] array;
        ListElement<T> firstElement;
        int currentIndex = 0;
        int count = 0;
        public MyList()
        {

        }
        public void Add(T element)
        {   
            if(count==0)
            {
                firstElement = new ListElement<T>(element);
                count++;
                currentIndex = 0;
            }
            else
            {
                ListElement<T> ele = new ListElement<T>(element);
                
                firstElement.nextElement = ele;
                currentIndex++;
                count++;    

            }

         
            //ListElement<T> le = new ListElement<T>(element);  
            //if(array.Length == 0)
            //{
            //    array = new ListElement<T>[] { le };   
            //}
        }
        public ListElement<T> IndexOf(int index)
        {

            ListElement<T> ele = firstElement;
            for(int i = 0; i <= index; i++)
            {
                ele = ele.nextElement;  
            }
            return ele;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> list = new LinkedList<int>();
            list.AddFirst(1);
            list.AddLast(2);
            list.AddFirst(3);
            list.AddLast(4);
            list.AddFirst(4);
            list.Count(); 
            foreach(int i in list)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
            
        }
        
    }
}

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
            char[] array = InputArray();
            CesarMethod(array);
            OutputGivenArray(ref array);
            Console.ReadKey();
        }
        #region Methods
        static char[] InputArray()
        {
            char[] array = new char[20];
            Console.WriteLine("Enter elements of array  -->");
            for (int i = 0; i < 20; i++)
            {
                array[i] = (char)Console.Read();
            }
            Console.WriteLine("The given array -->");
            return array;
        }

        static void OutputGivenArray(ref char[]array)
        {
            int length = array.GetLength(0);
            for (int i = 0; i < length; i++)
            {
                Console.Write(array[i]);
            }
            Console.WriteLine();
        }

        static void CesarMethod(char[] array)
        {
            int length = array.GetLength(0);
            for(int i = 0; i < length; i++)
            {
                int b = Convert.ToInt16((char)array[i]) + 1;
                array[i]= Convert.ToChar(b);
            }
        }
    }
}
#endregion

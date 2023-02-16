using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @struct
{
    internal class Program
    {
        struct Welders
        {
            public int id;
            public string name;
            public string surname;
            public string fatherName;
            public double plannedAmount;
            public double usedAmount;
        }
        static void Main(string[] args)
        {
           Welders []welders = Input();
           ListOfSavings(welders);

           Console.ReadKey();
        }
        static Welders[] Input()
        {
            Welders[] welders = new Welders[4];

            welders[0].id = 1;
            welders[0].name = "Amil";
            welders[0].surname = "Babayev";
            welders[0].fatherName = "Baloglan";
            welders[0].plannedAmount = 30;
            welders[0].usedAmount = 29;

            welders[1].id = 2;
            welders[1].name = "Cavansir";
            welders[1].surname = "Hesenov";
            welders[1].fatherName = "Cavad";
            welders[1].plannedAmount = 30;
            welders[1].usedAmount = 30;

            welders[2].id = 3;
            welders[2].name = "Harry";
            welders[2].surname = "Maguire";
            welders[2].fatherName = "Jacob";
            welders[2].plannedAmount = 30;
            welders[2].usedAmount = 100000000;

            welders[3].id = 4;
            welders[3].name = "Mutellim";
            welders[3].surname = "Mutellimov";
            welders[3].fatherName = "Mutellim";
            welders[3].plannedAmount = 30;
            welders[3].usedAmount = 10;

            return welders;
        }

        static void ListOfSavings(Welders[]welders)
        {
            int length = welders.Length;
            for (int i = 0; i < length; i++)
            {
                if (welders[i].usedAmount < welders[i].plannedAmount)
                {
                    //Console.WriteLine("ID :"+welders[i].id);
                    //Console.WriteLine("Name :"+welders[i].name);
                    //Console.WriteLine("Surname :" + welders[i].surname);
                    //Console.WriteLine("Father's name :" + welders[i].fatherName);
                    //Console.WriteLine();
                    Console.WriteLine($"ID :  {welders[i].id} | Name : {welders[i].name} |");
                }
            }
        }
    }
}

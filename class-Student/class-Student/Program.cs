using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_Student
{
    class Student
    {
        string name;
        string surname;
        int age;
        double [] points = new double[5];
        double pension;
        int birth;
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = Math.Abs(value);
            }
        }

        public void setParametres()
        {
            Console.Write("Zehmet olmasa sagirdin adini daxil edin :");
            name = Console.ReadLine();
            Console.Write("Zehmet olmasa sagirdin soyadini daxil edin :");
            surname = Console.ReadLine();
        }

        public void arrayOfPoints()
        {
            int countsOfA = 0;
            int countsOfB = 0;
            int countsOfC = 0;
            int countsOfD = 0;
            int countsOfE = 0;
            int countsOfLowPoints = 0;
            Console.Write("Fenler uzre yekun ballari daxil edin :");
            for (int i = 0; i < 5; i++)
            {
                points[i] = double.Parse(Console.ReadLine());
                if (points[i] >= 91)
                {
                    countsOfA++;
                }
                if (points[i] >= 81 && points[i] < 91)
                {
                    countsOfB++;
                }
                if (points[i] >= 71 && points[i] < 81)
                {
                    countsOfC++;
                }
                if (points[i] >= 61 && points[i] < 71)
                {
                    countsOfD++;
                }
                if (points[i] >= 51 && points[i] < 61)
                {
                    countsOfE++;
                }
                if(points[i] < 51)
                {
                    countsOfLowPoints++;
                }
            }

            if(countsOfA == 5)
            {
                pension = 156;
            }
            if(countsOfLowPoints != 0)
            {
                pension = 0;
            }
            if (countsOfA >= 1 && countsOfA < 5 && countsOfD == 0 && countsOfE == 0 && countsOfLowPoints == 0)
            {
                pension = 132;
            }
            else
            {
                if(countsOfLowPoints == 0 && countsOfA !=5)
                {
                    pension = 90;
                }
                
            }
        }

        public void getParametres()
        {
            birth = 2022 - age;
            Console.WriteLine("Adi :" + name);
            Console.WriteLine("Soyadi :" + surname);
            Console.WriteLine("Tevelludu :" + birth);
            if (pension == 156)
            {
                Console.WriteLine("Elaci teqaudu");
            }
            if(pension == 132)
            {
                Console.WriteLine("Heveslendirici teqaud");
            }
            if(pension == 90)
            {
                Console.WriteLine("Adi teqaud");
            }
            if(pension == 0)
            {
                Console.WriteLine("Kesilib");
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student st = new Student();
            st.setParametres();
            Console.Write("Sagirdin yasini daxil edin :");  
            st.Age = int.Parse(Console.ReadLine());
            st.arrayOfPoints();
            st.getParametres();

            Console.ReadKey();
          
        }
    }
}

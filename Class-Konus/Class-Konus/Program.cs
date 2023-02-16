using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Konus
{
    class cone
    {
        double height;
        double volume;
        double totalSurface;
        double lateralSurface;
        double radius;
        double slantHeight;

        public double Hundurluk
        {
            get
            {
                return height;
            }
            set
            {
                height = Math.Abs(value);
            }
        }

        public double Radius
        {
            get
            {
                return radius;
            }
            set
            {
                radius = Math.Abs(value);
            }
        }

        public double calculatingOfVolume()
        {
            slantHeight = Math.Sqrt(radius * radius + height * height);
            volume = (Math.PI * radius * radius * height) / 3;
            return volume;
        }

        public double calculatingOfTotalSurface()
        {
            totalSurface = (Math.PI * radius * (radius + slantHeight));
            return totalSurface;
        }

        public double calculatingOfLateralSurface()
        {
            lateralSurface = (Math.PI * radius * slantHeight);
            return lateralSurface;
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            cone c = new cone();
            Console.Write("Konusun hundurluyunu daxil edin :");
            double hundurluk = double.Parse(Console.ReadLine());
            c.Hundurluk = hundurluk;
            Console.Write("Konusun oturacaginin radiusunu daxil edin:");
            double radius = double.Parse(Console.ReadLine());
            c.Radius = radius;
            Console.WriteLine($"Konusun hecmi = {c.calculatingOfVolume()}");
            Console.WriteLine($"Konusun tam sethinin sahesi = {c.calculatingOfTotalSurface()}");
            Console.WriteLine($"Konusun yan sethinin sahesi = {c.calculatingOfLateralSurface()}");

            Console.ReadKey();
        }
    }
}

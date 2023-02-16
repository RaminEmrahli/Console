using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;

namespace classes
{
    class Multangulars
    {
        double area;
        public double Area
        {
            get
            {
                return area;
            }
            set
            {
                area = value;
            }
        }

        double perimeter;
        public double Perimeter
        {
            get
            {
                return perimeter;
            }
            set
            {
                perimeter = value;
            }
        }

        string type;
        public string Type
        {
            get
            {
                return type;
            }
            set
            {
                type = value;
            }
        }

        public void PrintArea()
        {
            Console.WriteLine(type + " sahesi : " + area + " metr kvadratidir.");
        }
        public void PrintPerimeter()
        {
            Console.WriteLine(type + " perimetri : " + perimeter + " metrdir.");
        }
    }
    class Rectangular : Multangulars
    {
        int X;
        int Y;
        double side1;
        public double Side1
        {
            get
            {
                return side1;
            }
            set
            {
                side1 = Math.Abs(value);
            }
        }

        double side2;
        public double Side2
        {
            get
            {
                return side2;
            }
            set
            {
                side2 = Math.Abs(value);
            }
        }

        public Rectangular()
        {
            Console.Write("Duzbucaqlinin enini daxil edin : ");
            Side1 = double.Parse(Console.ReadLine());
            Console.Write("Duzbucaqlinin uzunlugunu daxil edin : ");
            Side2 = double.Parse(Console.ReadLine());
            Type = "Duzbucaqli";
        }
        public void DrawAndMoveRectangular(Graphics graphic)
        {
            int x1 = 1000;
            X = 20;
            Y = 20;
            int partX = (x1 - X) / 20;
            Brush brush = new SolidBrush(Color.Blue);
            int height = (int)side1 * 10;
            int width = (int)side2 * 10;
            graphic.FillRectangle(brush, X, Y, width, height);

            while(X < 1000)
            {
                brush = new SolidBrush(Color.White);
                graphic.FillRectangle(brush, X, Y, width, height);
                X = X + partX;
                brush = new SolidBrush(Color.Blue);
                graphic.FillRectangle(brush, X, Y, width, height);
                Thread.Sleep(300);
            }
        }
        public double CalgulateAreaOfRectangular()
        {
            Area = side1 * side2;
            return Area;
        }
        public double CalgulatePerimeterOfRectangular()
        {
            Perimeter = 2 * (side1 + side2);
            return Perimeter;
        }
    }
    class Circle : Multangulars
    {
        int X;
        int Y;
        double radius;
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
        public Circle()
        {
            Console.Write("Cevrenin radiusunu daxil edin : ");
            Radius = double.Parse(Console.ReadLine());
            Type = "Cevre";
        }

        public void DrawAndMoveCircle(Graphics graphic)
        {
            X = 20;
            Y = 100;
            int x1 = 1000;
            int partX = (x1 - X) / 20;
            int height = (int)radius * 2 * 10;
            int width = (int)radius * 2 * 10;
            Brush brush = new SolidBrush(Color.Red);
            graphic.FillEllipse(brush, X, Y, width, height);
            while (X < 1000)
            {
                brush = new SolidBrush(Color.White);
                graphic.FillEllipse(brush, X, Y, width, height);
                X = X + partX;
                brush = new SolidBrush(Color.Red);
                graphic.FillEllipse(brush, X, Y, width, height);
                Thread.Sleep(300);
            }

        }
        public double CalgulateAreaOfCircle()
        {
            Area = Math.PI * radius * radius;
            return Area;
        }
        public double CalgulateLenghtOfCircle()
        {
            Perimeter = Math.PI * radius * 2;
            return Perimeter;
        }

    }
    class Triangle : Multangulars
    {
        double side1;
        public double Side1
        {
            get
            {
                return side1;
            }
            set
            {
                side1 = Math.Abs(value);
            }
        }

        double side2;
        public double Side2
        {
            get
            {
                return side2;
            }
            set
            {
                side2 = Math.Abs(value);
            }
        }

        double side3;
        public double Side3
        {
            get
            {
                return side3;
            }
            set
            {
                side3 = Math.Abs(value);
            }
        }
    }
    class EqualSidesTriangle : Triangle
    {
        public EqualSidesTriangle()
        {
            Type = "Beraberyanli Ucbucaq";
            Console.Write("Beraberyanli ucbucagin yan terefini daxil edin : ");
            Side1 = double.Parse(Console.ReadLine());
            Side2 = Side1;
            Console.Write("Beraberyanli ucbucagin oturacaqini daxil edin : ");
            Side3 = double.Parse(Console.ReadLine());
            if (Side3 == Side1)
            {
                Console.WriteLine("Ucbucaq Berabertereflidir .");
                Type = "Beraberterefli Ucbucaq";
            }
        }
        public void DrawAndMoveTriangle(Graphics graphic)
        {
            int x = 100;
            int x1 = 1000;
            int partX = (x1 - x) / 15;
            Point p1 = new Point(100, 300);
            Point p2 = new Point(50 - (int)Side1, 500);
            Point p3 = new Point(100 + (int)Side1, 500);
            Brush brush = new SolidBrush(Color.Green);
            Point[] points = { p1, p2, p3 };
            graphic.FillPolygon(brush, points);

            while (x<1000)
            {
                brush = new SolidBrush(Color.White);
                graphic.FillPolygon(brush, points);
                x = x + partX;
                points[0] = new Point(100 + x, 300);
                points[1] = new Point(x+ 50 - (int)Side1, 500);
                points[2] = new Point(x + 150 + (int)Side1, 500);
                
                brush = new SolidBrush(Color.Green);
                graphic.FillPolygon(brush, points);
                Thread.Sleep(300);
            }
        }
        public double CalculateAreaOfEqualSidesTriangle()
        {
            double p = (Side1 + Side2 + Side3) / 2;
            Area = Math.Sqrt(p * (p - Side1) * (p - Side2) * (p - Side3));
            return Area;
        }
        public double CalculatePerimeterOfEqualSidesTriangle()
        {
            Perimeter = Side1 + Side2 + Side3;
            return Perimeter;
        }
    }
    class EquilateralTriangle : Triangle  
    {
        public EquilateralTriangle()
        {
            Type = "Beraberterefli Ucbucaq";
            Console.Write("Beraberterefli ucbucagin terefini daxil edin : ");
            Side1 = double.Parse(Console.ReadLine());
            Side2 = Side1;
            Side3 = Side2;
        }
        public double CalculateAreaOfEqualiteralTriangle()
        {
            Area = 4 * Side1 * Side1 * Math.Sqrt(3) / 2;
            return Area;
        }
        public double CalculatePerimeterOfEquilateralTriangle()
        {
            Perimeter = Side1 + Side2 + Side3;
            return Perimeter;
        }
    }
    class RightTriangle : Triangle  
    {
        public RightTriangle()
        {
            Type = "Duzbucaqli Ucbucaq";
            Console.Write("Duzbucaqli ucbucagin kicik katetini daxil edin : ");
            Side1 = double.Parse(Console.ReadLine());
            Console.Write("Duzbucaqli ucbucagin boyuk katetini daxil edin : ");
            Side2 = double.Parse(Console.ReadLine());
            Side3 = Math.Sqrt(Side1 * Side1 + Side2 * Side2);
        }
        public double CalculateAreaOfRightTriangle()
        {
            double p = (Side1 + Side2 + Side3) / 2;
            Area = Math.Sqrt(p * (p - Side1) * (p - Side2) * (p - Side3));
            return Area;
        }
        public double CalculatePerimeterOfRightTriangle()
        {
            Perimeter = Side1 + Side2 + Side3;
            return Perimeter;
        }
    }
    internal class Program
    {

        static void Main(string[] args)
        { 
            Form mainform = new Form();
            mainform.WindowState = FormWindowState.Maximized;
            mainform.Show();
            Graphics canvas = mainform.CreateGraphics();
            mainform.BackColor = Color.White;         
            #region Rectangular
            Rectangular rect = new Rectangular();
            rect.CalgulateAreaOfRectangular();
            rect.CalgulatePerimeterOfRectangular();
            rect.PrintArea();
            rect.PrintPerimeter();
            rect.DrawAndMoveRectangular(canvas);
            Console.WriteLine();
            Console.WriteLine();
            #endregion
            #region Circle
            Circle circ = new Circle();
            circ.CalgulateAreaOfCircle();
            circ.CalgulateLenghtOfCircle();
            circ.PrintArea();
            circ.PrintPerimeter();
            circ.DrawAndMoveCircle(canvas);
            Console.WriteLine();
            Console.WriteLine();
            #endregion
            #region EqualSidesTriangle
            EqualSidesTriangle U1 = new EqualSidesTriangle();
            U1.CalculateAreaOfEqualSidesTriangle();
            U1.CalculatePerimeterOfEqualSidesTriangle();
            U1.PrintArea();
            U1.PrintPerimeter();
            U1.DrawAndMoveTriangle(canvas);
            Console.WriteLine();
            Console.WriteLine();
            #endregion
            #region EquilateralTriangle
            EquilateralTriangle U2 = new EquilateralTriangle();
            U2.CalculateAreaOfEqualiteralTriangle();
            U2.CalculatePerimeterOfEquilateralTriangle();
            U2.PrintArea();
            U2.PrintPerimeter();
            Console.WriteLine();
            Console.WriteLine();
            #endregion
            #region RightTriangle
            RightTriangle U3 = new RightTriangle();
            
            U3.CalculateAreaOfRightTriangle();
            U3.CalculatePerimeterOfRightTriangle();
            U3.PrintArea();
            U3.PrintPerimeter();
            #endregion

            Console.ReadLine();
        }
    }
}

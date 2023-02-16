using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace funksiya
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t\t***** Hendesi fiqurlar kakulyatoruna xos gelmisiniz!!! *****\t\t\t");
            Console.WriteLine("Menyuya kecmek ucun 'M' duymesini sixin\n");
            Console.WriteLine();
            ConsoleKeyInfo key = new ConsoleKeyInfo();
            ConsoleKeyInfo key1 = new ConsoleKeyInfo();
            ConsoleKeyInfo key2 = new ConsoleKeyInfo();
            ConsoleKeyInfo key3 = new ConsoleKeyInfo();
            ConsoleKeyInfo key4 = new ConsoleKeyInfo();

            bool GoToTriangles = false;
            bool GoTo2d3dFiqurlar = false;
            bool GoTo2dFiqurlar = false;
            bool GoTo3dFiqurlar = false;
            bool GoToMenu = false;

            while (true)
            {
                if (!GoToMenu)
                {
                    key = Console.ReadKey(true);
                }
                switch (key.Key)
                {
                    case ConsoleKey.M:
                        {
                            Console.Clear();
                            Menyu();
                            if (!GoTo2d3dFiqurlar)
                            {
                                key1 = Console.ReadKey(true);
                            }
                            switch (key1.Key)
                            {
                                case ConsoleKey.D2:
                                    {
                                        Console.Clear();
                                        fiqur2d();
                                        if (!GoTo2dFiqurlar)
                                        {
                                            key2 = Console.ReadKey(true);
                                        }
                                        switch (key2.Key)
                                        {
                                            case ConsoleKey.Escape:
                                                {
                                                    GoToMenu = true;
                                                    GoTo2d3dFiqurlar = false;
                                                }
                                                break;
                                            case ConsoleKey.K:
                                                {
                                                    Console.Clear();
                                                    Console.Write("Kvadratin terefini daxil edin:");
                                                    double kvteref = double.Parse(Console.ReadLine());
                                                    Console.WriteLine();
                                                    double kvperimetr;
                                                    double kvsahe;
                                                    Kvadrat(kvteref, out kvperimetr, out kvsahe);
                                                    Console.WriteLine($"Kvadratin sahesi={kvsahe}");
                                                    Console.WriteLine($"Kvadratin perimetri={kvperimetr}");
                                                    Console.WriteLine("\n\nHer hansi duymeni sixin.");
                                                    Console.ReadKey(true);
                                                    GoToMenu = true;
                                                    GoTo2d3dFiqurlar = true;
                                                    GoTo2dFiqurlar = false;
                                                }
                                                break;
                                            case ConsoleKey.D:
                                                {
                                                    Console.Clear();
                                                    Console.Write("Duzbucaqlinin enini daxil edin:");
                                                    double dteref1 = double.Parse(Console.ReadLine());
                                                    Console.Write("Duzbucaqlinin uzunluqunu daxil edin:");
                                                    double dteref2 = double.Parse(Console.ReadLine());
                                                    Console.WriteLine();
                                                    double dsahe;
                                                    double dperimetr;
                                                    Duzbucaqli(dteref1, dteref2, out dsahe, out dperimetr);
                                                    Console.WriteLine($"Duzbucaqlinin sahesi={dsahe}");
                                                    Console.WriteLine($"Duzbucaqlinin perimetri={dperimetr}");
                                                    Console.WriteLine("\n\nHer hansi duymeni sixin.");
                                                    Console.ReadKey(true);
                                                    GoToMenu = true;
                                                    GoTo2d3dFiqurlar = true;
                                                    GoTo2dFiqurlar = false;
                                                }
                                                break;
                                            case ConsoleKey.P:
                                                {
                                                    Console.Clear();
                                                    Console.Write("Paraleloqramin enini daxil edin:");
                                                    double prllteref1 = double.Parse(Console.ReadLine());
                                                    Console.Write("Paraleloqramin uzunluqunu daxil edin:");
                                                    double prllteref2 = double.Parse(Console.ReadLine());
                                                    Console.Write("Paraleloqram itibucaqini daxil edin:");
                                                    double prllitibucaq = double.Parse(Console.ReadLine());
                                                    Console.WriteLine();
                                                    double prllsahe;
                                                    double prllperimetr;
                                                    Paraleloqram(prllteref1, prllteref2, prllitibucaq, out prllsahe, out prllperimetr);
                                                    Console.WriteLine($"Duzbucaqlinin sahesi={prllsahe}");
                                                    Console.WriteLine($"Duzbucaqlinin perimetri={prllperimetr}");
                                                    Console.WriteLine("\n\nHer hansi duymeni sixin.");
                                                    Console.ReadKey(true);
                                                    GoToMenu = true;
                                                    GoTo2d3dFiqurlar = true;
                                                    GoTo2dFiqurlar = false;
                                                }
                                                break;
                                            case ConsoleKey.R:
                                                {
                                                    Console.Clear();
                                                    Console.Write("Rombun terefini daxil edin:");
                                                    double rteref = double.Parse(Console.ReadLine());
                                                    Console.Write("Rombun itibucaqini daxil edin:");
                                                    double ritibucaq = double.Parse(Console.ReadLine());
                                                    Console.WriteLine();
                                                    double rsahe;
                                                    double rperimetr;
                                                    Romb(rteref, ritibucaq, out rsahe, out rperimetr);
                                                    Console.WriteLine($"Rombun sahesi={rsahe}");
                                                    Console.WriteLine($"Rombun perimetri={rperimetr}");
                                                    Console.WriteLine("\n\nHer hansi duymeni sixin.");
                                                    Console.ReadKey(true);
                                                    GoToMenu = true;
                                                    GoTo2d3dFiqurlar = true;
                                                    GoTo2dFiqurlar = false;
                                                }
                                                break;
                                            case ConsoleKey.T:
                                                {
                                                    Console.Clear();
                                                    Console.Write("Trapesiyanin kicik oturacaqini daxil edin:");
                                                    double oturacaq1 = double.Parse(Console.ReadLine());
                                                    Console.Write("Trapesiyanin boyuk oturacaqini daxil edin:");
                                                    double oturacaq2 = double.Parse(Console.ReadLine());
                                                    Console.Write("Trapesiyanin yan terefini daxil edin:");
                                                    double yanteref1 = double.Parse(Console.ReadLine());
                                                    Console.Write("Trapesiyanin diger yan terefini daxil edin:");
                                                    double yanteref2 = double.Parse(Console.ReadLine());
                                                    Console.Write("Trapesiyanin hundurluyunu daxil edin:");
                                                    double hundurluk = double.Parse(Console.ReadLine());
                                                    Console.WriteLine();
                                                    double tsahe;
                                                    double tperimetr;
                                                    Trapesiya(oturacaq1, oturacaq2, yanteref1, yanteref2, hundurluk, out tsahe, out tperimetr);
                                                    Console.WriteLine($"Trapesiyanin sahesi={tsahe}");
                                                    Console.WriteLine($"Trapesiyanin perimetri={tperimetr}");
                                                    Console.WriteLine("\n\nHer hansi duymeni sixin."); 
                                                    Console.ReadKey(true);
                                                    GoToMenu = true;
                                                    GoTo2d3dFiqurlar = true;
                                                    GoTo2dFiqurlar = false;
                                                }
                                                break;
                                            case ConsoleKey.C:
                                                {
                                                    Console.Clear();
                                                    Console.Write("Cevrenin radiusunu daxil edin:");
                                                    double radius = double.Parse(Console.ReadLine());
                                                    double uzunluq;
                                                    double cevreninsahesi;
                                                    Cevre(radius, out uzunluq, out cevreninsahesi);
                                                    Console.WriteLine();
                                                    Console.Write($"Cevrenin uzunluqu={uzunluq}");
                                                    Console.WriteLine();
                                                    Console.Write($"Cevrenin sahesi={cevreninsahesi}");
                                                    Console.WriteLine("\n\nHer hansi duymeni sixin.");
                                                    Console.ReadKey(true);
                                                    GoToMenu = true;
                                                    GoTo2d3dFiqurlar = true;
                                                    GoTo2dFiqurlar = false;
                                                }
                                                break;
                                            case ConsoleKey.U:
                                                {
                                                    Console.Clear();
                                                    Ucbucaqlar();
                                                    if (!GoToTriangles)
                                                    {
                                                        key4 = Console.ReadKey(true);
                                                    }
                                                    switch (key4.Key)
                                                    {
                                                        case ConsoleKey.F3:
                                                            {
                                                                Console.Clear();
                                                                Console.Write("Ucbucaqin 1-ci terefini daxil edin:");
                                                                double teref1 = double.Parse(Console.ReadLine());
                                                                Console.Write("Ucbucaqin 2-ci terefini daxil edin:");
                                                                double teref2 = double.Parse(Console.ReadLine());
                                                                Console.Write("Ucbucaqin 3-cu terefini daxil edin:");
                                                                double teref3 = double.Parse(Console.ReadLine());
                                                                Console.WriteLine();
                                                                double sahe;
                                                                double perimetr;
                                                                ixtUcbucaq(teref1, teref2, teref3, out sahe, out perimetr);
                                                                Console.WriteLine($"Ucbucaqin sahesi={sahe}");
                                                                Console.WriteLine($"Ucbucaqin perimetri={perimetr}");
                                                                Console.WriteLine("\n\nHer hansi duymeni sixin.");
                                                                Console.ReadKey(true);
                                                                GoToMenu = true;
                                                                GoTo2d3dFiqurlar = true;
                                                                GoTo2dFiqurlar = true;
                                                                GoToTriangles = false;
                                                            }
                                                            break;
                                                        case ConsoleKey.F4:
                                                            {
                                                                Console.Clear();
                                                                Console.Write("Duzbucaqli ucbucaqin kicik katetini daxil edin:");
                                                                double duzteref1 = double.Parse(Console.ReadLine());
                                                                Console.Write("Duzbucaqli ucbucaqin boyuk katetini daxil edin:");
                                                                double duzteref2 = double.Parse(Console.ReadLine());
                                                                Console.WriteLine();
                                                                double duzsahe;
                                                                double duzperimetr;
                                                                duzUcbucaq(duzteref1, duzteref2, out duzsahe, out duzperimetr);
                                                                Console.WriteLine($"Duzbucaqli ubucaqin sahesi={duzsahe}");
                                                                Console.WriteLine($"Duzbucaqli ucbucaqin perimetri={duzperimetr}");
                                                                Console.WriteLine("\n\nHer hansi duymeni sixin."); 
                                                                Console.ReadKey(true);
                                                                GoToMenu = true;
                                                                GoTo2d3dFiqurlar = true;
                                                                GoTo2dFiqurlar = true;
                                                                GoToTriangles = false;
                                                            }
                                                            break;
                                                        case ConsoleKey.F5:
                                                            {
                                                                Console.Clear();
                                                                Console.Write("Beraberterefli ucbucaqin terefini daxil edin:");
                                                                double duzgunteref = double.Parse(Console.ReadLine());
                                                                Console.WriteLine();
                                                                double duzgunsahe;
                                                                double duzgunperimetr;
                                                                duzgunUcbucaq(duzgunteref, out duzgunsahe, out duzgunperimetr);
                                                                Console.WriteLine($"Beraberterefli ucbucaqin sahesi={duzgunsahe:F1}");
                                                                Console.WriteLine($"Beraberterefli ucbucaqin perimetri={duzgunperimetr}");
                                                                Console.WriteLine("\n\nHer hansi duymeni sixin.");
                                                                Console.ReadKey(true);
                                                                GoToMenu = true;
                                                                GoTo2d3dFiqurlar = true;
                                                                GoTo2dFiqurlar = true;
                                                                GoToTriangles = false;
                                                            }
                                                            break;
                                                        case ConsoleKey.Escape:
                                                            {
                                                                GoToMenu = true;
                                                                GoTo2d3dFiqurlar = true;
                                                                GoTo2dFiqurlar = false;
                                                            }
                                                            break;
                                                    }
                                                }
                                                break;
                                        }
                                    }
                                    break;
                                case ConsoleKey.D3:
                                    {

                                        Console.Clear();
                                        fiqur3d();
                                        if (!GoTo3dFiqurlar)
                                        {
                                            key3 = Console.ReadKey(true);
                                        }
                                        switch (key3.Key)
                                        {
                                            case ConsoleKey.Escape:
                                                {
                                                    GoToMenu = true;
                                                    GoTo2d3dFiqurlar = false;
                                                }
                                                break;
                                            case ConsoleKey.F1:
                                                {
                                                    Console.Clear();
                                                    Console.Write("Kubun tilini daxil edin:");
                                                    double kubteref = double.Parse(Console.ReadLine());
                                                    double ktamsahe;
                                                    double kyansahe;
                                                    double khecm;
                                                    Kub(kubteref, out ktamsahe, out kyansahe, out khecm);
                                                    Console.WriteLine($"Kubun tam sethinin sahesi={ktamsahe} ");
                                                    Console.WriteLine($"Kubun yan sethinin sahesi={kyansahe} ");
                                                    Console.WriteLine($"Kubun hecmi={khecm} ");
                                                    Console.WriteLine("\n\nHer hansi duymeni sixin.");
                                                    Console.ReadKey(true);
                                                    GoToMenu = true;
                                                    GoTo2d3dFiqurlar = true;
                                                    GoTo3dFiqurlar = false;
                                                }
                                                break;
                                            case ConsoleKey.F2:
                                                {
                                                    Console.Clear();
                                                    Console.Write("Paralelepipedin enini daxil edin:");
                                                    double en = double.Parse(Console.ReadLine());
                                                    Console.Write("Paralelepipedin uzunluqunu daxil edin:");
                                                    double uzunluq = double.Parse(Console.ReadLine());
                                                    Console.Write("Paralelepipedin hundurluyunu daxil edin:");
                                                    Console.WriteLine();
                                                    double hundurluk = double.Parse(Console.ReadLine());
                                                    double ptamsahe;
                                                    double pyansahe;
                                                    double phecm;
                                                    Paralelepiped(en, uzunluq, hundurluk, out ptamsahe, out pyansahe, out phecm);
                                                    Console.WriteLine($"Paralelepipedin tam sethinin sahesi={ptamsahe}");
                                                    Console.WriteLine($"Paralelepipedin yan sethinin sahesi={pyansahe}");
                                                    Console.WriteLine($"Paralelepipedin hecmi={phecm}");
                                                    Console.WriteLine("\n\nHer hansi duymeni sixin.");
                                                    Console.ReadKey(true);
                                                    GoToMenu = true;
                                                    GoTo2d3dFiqurlar = true;
                                                    GoTo3dFiqurlar = false;
                                                }
                                                break;
                                        }

                                    }
                                    break;
                            }
                        }
                        break;
                }
            }
            Console.ReadKey(true);
        }
        #region Metods
        static void Kvadrat(double kvteref, out double kvperimetr, out double kvsahe)
        {
            kvperimetr = 4 * kvteref;
            kvsahe = Math.Pow(kvteref, 2);
        }
        static void Duzbucaqli(double dteref1, double dteref2, out double dsahe, out double dperimetr)
        {
            dsahe = dteref1 * dteref2;
            dperimetr = 2 * (dteref1 + dteref2);
        }
        static void Paraleloqram(double prllteref1, double prllteref2, double prllitibucaq, out double prllsahe, out double prllperimetr)
        {
            prllsahe = prllteref1 * prllteref2 * Math.Sin(Math.PI / (180 / prllitibucaq));
            prllperimetr = 2 * (prllteref1 + prllteref2);
        }
        static void Romb(double rteref, double ritibucaq, out double rsahe, out double rperimetr)
        {
            rperimetr = rteref * 4;
            rsahe = rteref * rteref * Math.Sin(Math.PI / (180 / ritibucaq));
        }
        static void Trapesiya(double oturacaq1, double oturacaq2, double yaneref1, double yanteref2, double hundurluk, out double tsahe, out double tperimetr)
        {
            tperimetr = oturacaq1 + oturacaq2 + yaneref1 + yanteref2;
            tsahe = ((oturacaq1 + oturacaq2) / (2)) * hundurluk;
        }
        static void ixtUcbucaq(double teref1, double teref2, double teref3, out double sahe, out double perimetr)
        {
            perimetr = teref1 + teref2 + teref3;
            sahe = Math.Sqrt((perimetr / 2) * ((perimetr / 2) - teref1) * ((perimetr / 2) - teref2) * ((perimetr / 2) - teref3));
        }
        static void duzUcbucaq(double duzteref1, double duzteref2, out double duzsahe, out double duzperimetr)
        {
            duzsahe = duzteref1 * duzteref2 / 2;
            duzperimetr = duzteref1 + duzteref2 + Math.Sqrt(duzteref1 * duzteref1 + duzteref2 * duzteref2);
        }
        static void duzgunUcbucaq(double duzgunteref, out double duzgunsahe, out double duzgunperimetr)
        {
            duzgunsahe = duzgunteref * duzgunteref * Math.Sqrt(3) / 4;
            duzgunperimetr = 3 * duzgunteref;
        }
        static void Cevre(double radius, out double uzunluq, out double cevreninsahesi)
        {
            cevreninsahesi = Math.PI * radius * radius;
            uzunluq = 2 * Math.PI * radius;
        }
        static void Kub(double kubteref, out double ktamsahe, out double kyansahe, out double khecm)
        {
            khecm = kubteref * kubteref * kubteref;
            kyansahe = kubteref * kubteref * 4;
            ktamsahe = kubteref * kubteref * 6;
        }
        static void Paralelepiped(double en, double uzunluq, double hundurluk, out double ptamsahe, out double pyansahe, out double phecm)
        {
            ptamsahe = 2 * (en * uzunluq + en * hundurluk + hundurluk * uzunluq);
            pyansahe = 2 * (en * hundurluk + hundurluk * uzunluq);
            phecm = en * uzunluq * hundurluk;
        }
        static void Menyu()
        {
            Console.WriteLine("--->2d fiqurlar ucun '2' duymesini sixin.");
            Console.WriteLine("--->3d fiqurlar ucun '3' duymesini sixin.");
        }
        static void fiqur2d()
        {
            Console.WriteLine("--->Kvadrat ucun 'K' duymesini sixin.");
            Console.WriteLine("--->Duzbucaqli ucun 'D' duymesini sixin.");
            Console.WriteLine("--->Paraleloqram ucun 'P' duymesini sixin.");
            Console.WriteLine("--->Romb ucun 'R' duymesini sixin.");
            Console.WriteLine("--->Trapesiya ucun 'T' duymesini sixin.");
            Console.WriteLine("--->Ucbucaq novleri ucun 'U' duymesini sixin.");
            Console.WriteLine("--->Cevre 'C' duymesini sixin.");
            Console.WriteLine("\n--->Geri qayitmaq ucun 'ESC' duymesini sixin.");
        }
        static void fiqur3d()
        {
            Console.WriteLine("--->Kub ucun funksional duymelerden 'F1' duymesini sixin.");
            Console.WriteLine("--->Duzbucaqli Paralelepiped ucun funksional duymelerden 'F2' duymesini sixin.");
            Console.WriteLine("\n--->Geri qayitmaq ucun 'ESC' duymesini sixin.");
        }
        static void Ucbucaqlar()
        {
            Console.WriteLine("--->Ixtiyari ucbucaq ucun funksional duymelerden 'F3' duymesini sixin.\n");
            Console.WriteLine("---> Duzbucaqli ucbucaq ucun funksional duymelerden 'F4' duymesini sixin.\n");
            Console.WriteLine("---> Beraberterefli ucbucaq ucun funksional duymelerden 'F5' duymesini sixin.\n");
            Console.WriteLine("\n--->Geri qayitmaq ucun 'ESC' duymesini sixin.");
        }
        #endregion
    }
}
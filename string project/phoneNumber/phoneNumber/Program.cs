using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace phoneNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[,] cityCodes =
            {
                {"Baki","12"},
                {"Sumqayit","18"},
                {"Berde","2020"},
                {"Ucar","2021"},
                {"Agsu","2022"},
                {"Agdas","2023"},
                {"Qobustan","2024"},
                {"Kurdemir","2025"},
                {"Samaxi","2026"},
                {"Goycay","2027"},
                {"Ismayilli","2028"},
                {"Zerdab","2029"},
                {"Haciqabul","2120"},
                {"Sirvan","2121"},
                {"Beyleqan","2122"},
                {"Sabirabad","2123"},
                {"Imisli","2124"},
                {"Salyan","2125"},
                {"Neftcala","2126"},
                {"Agcabedi","2127"},
                {"Saatli","2128"},
                {"Goygol","2220"},
                {"Daskesen","2221"},
                {"Agstafa","2222"},
                {"Gence","2225"},
                {"Terter","2223"},
                {"Goranboy","2224"},
                {"Samux","2227"},
                {"Qazax","2229"},
                {"Semkir","2230"},
                {"Tovuz","2231"},
                {"Gedebey","2232"},
                {"Yevlax","2233"},
                {"Naftalan","2235"},
                {"Siyezen","2330"},
                {"Xizi","2331"},
                {"Xacmaz","2332"},
                {"Quba","2333"},
                {"Sabran","2335"},
                {"Qusar","2338"},
                {"Qebele","2420"},
                {"Oguz","2421"},
                {"Zaqatala","2422"},
                {"Seki","2424"},
                {"Qax","2425"},
                {"Mingecevir","2427"},
                {"Balaken","2429"},
                {"Nar Mobile","70" },
                {"Nar Mobile","77" },
                {"Bakcell","55" },
                {"Azercell","51" },
                {"Azercell","50" }
            };
            Console.WriteLine("\t\t\t\t\t\t*****Xos Gelmisiniz!*****\t\t");
            Console.WriteLine();
            FindingCodesOfRegion(cityCodes);
            Console.ReadKey();
        }

        static void FindingCodesOfRegion(string[,] cityCodes)
        {
            while (true)
            {
                Console.Write("Zehmet olmasa nomreni daxil edin : ");
                string nomre = Console.ReadLine();
                nomre = nomre.Replace(" ", "");
                nomre = nomre.Replace("-", "");
                nomre = nomre.Replace("(", "");
                nomre = nomre.Replace(")", "");
                bool flag = false;
                int countOFFindings = 0;
                if (nomre == String.Empty)
                {
                    break;
                }

                if (nomre[0] == '+' || nomre[0] >= 48 && nomre[0] <= 57)
                {
                    for (int i = 0; i < nomre.Length; i++)
                    {
                        if (nomre[i] >= 48 && nomre[i] < 57)
                        {
                            flag = true;
                        }
                        else
                        {
                            flag = false;
                        }
                    }
                }

                if ((nomre.StartsWith("+994") && nomre.Length != 13) || (nomre.StartsWith("00994") && nomre.Length != 14)
                || (nomre.StartsWith("0") && nomre[1] != '0' && nomre.Length != 10) || (nomre.StartsWith("+0")) || (nomre.StartsWith("0994"))
                || (nomre.Length < 10) || (!flag) || nomre.StartsWith("994") || (nomre.StartsWith("00") && nomre.Substring(0,5)!="00994"))
                {
                    Console.WriteLine("Nomre duzgun daxil edilmeyib!");
                    Console.WriteLine();
                }
                else
                {
                    for (int i = 0; i < cityCodes.GetLength(0); i++)
                    {
                        for (int j = 1; j < cityCodes.GetLength(1); j++)
                        {
                            if (nomre.StartsWith("0") && nomre[1] != '0')
                            {
                                if (nomre.Substring(1, 2) == cityCodes[i, j] || nomre.Substring(1, 4) == cityCodes[i, j])
                                {
                                    countOFFindings++;
                                    Console.WriteLine("Bu nomre " + cityCodes[i, 0] + " nomresidir");
                                    Console.WriteLine();
                                    break;
                                }
                                else
                                {
                                    if (i == cityCodes.GetLength(0) - 1 && countOFFindings == 0)
                                    {
                                        Console.WriteLine("Nomre teyin olunmayib !");
                                        break;
                                    }
                                }
                            }

                            if (nomre.StartsWith("00994"))
                            {
                                if (nomre.Substring(5, 2) == cityCodes[i, j] || nomre.Substring(5, 4) == cityCodes[i, j])
                                {
                                    countOFFindings++;
                                    Console.WriteLine("Bu nomre " + cityCodes[i, 0] + " nomresidir");
                                    Console.WriteLine();
                                    break;
                                }
                                else
                                {
                                    if (i == cityCodes.GetLength(0) - 1 && countOFFindings == 0)
                                    {
                                        Console.WriteLine("Nomre teyin olunmayib !");
                                        break;
                                    }
                                }
                            }

                            if (nomre.StartsWith("+994"))
                            {
                                if (nomre.Substring(4, 2) == cityCodes[i, j] || nomre.Substring(4, 4) == cityCodes[i, j])
                                {
                                    countOFFindings++;
                                    Console.WriteLine("Bu nomre " + cityCodes[i, 0] + " nomresidir");
                                    Console.WriteLine();
                                    break;
                                }
                                else
                                {
                                    if (i == cityCodes.GetLength(0)-1 && countOFFindings == 0)
                                    {
                                        Console.WriteLine("Nomre teyin olunmayib !");
                                        break;
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {

            int DO = 261;
            int RE = 293;
            int MI = 329;
            int FA = 349;
            int SOL = 391;
            int LYA = 440;
            int SI = 493;
            
            while (true)
            {
                ConsoleKeyInfo key = Console.ReadKey();
                switch (key.Key)
                {
                    case ConsoleKey.D1:
                        {
                            Console.Beep(DO, 200);
                        }
                        break;

                    case ConsoleKey.D2:
                        {
                            Console.Beep(RE, 200);
                        }
                        break;

                    case ConsoleKey.D3:
                        {
                            Console.Beep(MI, 200);
                        }
                        break;
                    case ConsoleKey.D4:
                        {
                            Console.Beep(FA, 200);
                        }
                        break;
                    case ConsoleKey.D5:
                        {
                            Console.Beep(SOL, 200);
                        }
                        break;
                    case ConsoleKey.D6:
                        {
                            Console.Beep(LYA, 200);
                        }
                        break;
                    case ConsoleKey.D7:
                        {
                            Console.Beep(SI, 200);
                        }
                        break;
                }
            }

        }
    }
}

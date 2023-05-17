using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace epilepsy.co.uk
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            int num1 = 0;
            Random rnd = new Random();
            num1 = rnd.Next(0,6);
            while (true)
            {
                string[] colours = new string[5] { "red", "white", "yellow", "magenta", "blue" };
                int backColour = rnd.Next(0, 5);
                if (backColour == 0)
                {
                    Console.BackgroundColor = ConsoleColor.Red; 
                    Console.Write(num);
                    num++;
                }
                if (backColour == 1)
                {
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.Write(num);
                    num++;
                }
                if (backColour == 2)
                {
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.Write(num);
                    num++;
                }
                if (backColour == 3)
                {
                    Console.BackgroundColor = ConsoleColor.Magenta;
                    Console.Write(num);
                    num++;
                }
                if (backColour == 4)
                {
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.Write(num);
                    num++;
                }

                int frontColour = rnd.Next(0, 5);
                if (frontColour == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(num);
                    num++;
                }
                if (frontColour == 1)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(num);
                    num++;
                }
                if (frontColour == 2)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write(num);
                    num++;
                }
                if (frontColour == 3)
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.Write(num);
                    num++;
                }
                if (frontColour == 4)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write(num);
                    num++;
                }
            }

                while (true)
            {
                num1 = rnd.Next(0, 6);
                switch (num1)
                {
                    case 1:
                        Console.BackgroundColor = ConsoleColor.Blue; 
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(num);
                        Console.WriteLine(num);
                        Console.WriteLine(num);
                        Console.WriteLine(num);
                        Console.WriteLine(num);
                        Console.WriteLine(num);
                        Console.WriteLine(num);
                        Console.WriteLine(num);
                        Console.WriteLine(num);
                        Console.WriteLine(num);
                        Console.WriteLine(num);
                        Console.WriteLine(num);
                        Console.WriteLine(num);
                        Console.WriteLine(num);
                        Console.WriteLine(num);
                        Console.WriteLine(num);
                        Console.WriteLine(num);
                        Console.WriteLine(num);
                        Console.WriteLine(num);
                        Console.WriteLine(num);
                        num++;
                        break;
                    case 2:
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.BackgroundColor = ConsoleColor.Yellow;
                        Console.WriteLine(num);
                        Console.WriteLine(num);
                        Console.WriteLine(num);
                        Console.WriteLine(num);
                        Console.WriteLine(num);
                        Console.WriteLine(num);
                        Console.WriteLine(num);
                        Console.WriteLine(num);
                        Console.WriteLine(num);
                        Console.WriteLine(num);
                        Console.WriteLine(num);
                        Console.WriteLine(num);
                        Console.WriteLine(num);
                        Console.WriteLine(num);
                        Console.WriteLine(num);
                        Console.WriteLine(num);
                        Console.WriteLine(num);
                        Console.WriteLine(num);
                        Console.WriteLine(num);
                        Console.WriteLine(num);
                        num++;
                        break;
                    case 3:
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine(num);
                        Console.WriteLine(num);
                        Console.WriteLine(num);
                        Console.WriteLine(num);
                        Console.WriteLine(num);
                        Console.WriteLine(num);
                        Console.WriteLine(num);
                        Console.WriteLine(num);
                        Console.WriteLine(num);
                        Console.WriteLine(num);
                        Console.WriteLine(num);
                        Console.WriteLine(num);
                        Console.WriteLine(num);
                        Console.WriteLine(num);
                        Console.WriteLine(num);
                        Console.WriteLine(num);
                        Console.WriteLine(num);
                        Console.WriteLine(num);
                        Console.WriteLine(num);
                        Console.WriteLine(num);
                        num++;
                        break;
                    case 4:
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(num);
                        Console.WriteLine(num);
                        Console.WriteLine(num);
                        Console.WriteLine(num);
                        Console.WriteLine(num);
                        Console.WriteLine(num);
                        Console.WriteLine(num);
                        Console.WriteLine(num);
                        Console.WriteLine(num);
                        Console.WriteLine(num);
                        Console.WriteLine(num);
                        Console.WriteLine(num);
                        Console.WriteLine(num);
                        Console.WriteLine(num);
                        Console.WriteLine(num);
                        Console.WriteLine(num);
                        Console.WriteLine(num);
                        Console.WriteLine(num);
                        Console.WriteLine(num);
                        Console.WriteLine(num);
                        num++;
                        break;
                    case 5:
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine(num);
                        Console.WriteLine(num);
                        Console.WriteLine(num);
                        Console.WriteLine(num);
                        Console.WriteLine(num);
                        Console.WriteLine(num);
                        Console.WriteLine(num);
                        Console.WriteLine(num);
                        Console.WriteLine(num);
                        Console.WriteLine(num);
                        Console.WriteLine(num);
                        Console.WriteLine(num);
                        Console.WriteLine(num);
                        Console.WriteLine(num);
                        Console.WriteLine(num);
                        Console.WriteLine(num);
                        Console.WriteLine(num);
                        Console.WriteLine(num);
                        Console.WriteLine(num);
                        Console.WriteLine(num);
                        num++;
                        break;

                    default:
                        break;
                }
            }
            Console.ReadLine();
        }
    }
}

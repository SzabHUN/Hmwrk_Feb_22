﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace N_Szab_Homewrk_Feb_22
{
    class Program
    {
        static void Main(string[] args)
        {
            String binary = String.Empty, to = String.Empty, from = String.Empty;
            /*
                        Thread.Sleep(1000);
                        Console.WriteLine("Please choose a base, you want to transform the number from:\n");
                        Thread.Sleep(600);
                        Console.WriteLine("Binary\t- 2");
                        Thread.Sleep(500);
                        Console.WriteLine("Octal\t- 8");
                        Thread.Sleep(500);
                        Console.WriteLine("Decimal\t - 10");
                        Thread.Sleep(500);
                        Console.WriteLine("Hexadecimal\t- 16");
                        Thread.Sleep(500);
                        Console.WriteLine("Hexavigesimal\t- 26");
                        Thread.Sleep(500);
                        Console.WriteLine("Sexagesimal\t- 60\n");

                        from = Console.ReadLine().ToUpper();

                        Console.WriteLine();
            */
            from = "Decimal".ToUpper();

            Console.WriteLine("Please enter a number, that you want to convert from (the) {0} base: ",from);

            int input = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            Thread.Sleep(50);
            if (from == "BINARY")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Binary\t- 2");
                Console.ForegroundColor = ConsoleColor.Gray;
            }
            else
            Console.WriteLine("Binary\t- 2");
            Thread.Sleep(50);

            if (from == "OCTAL")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Octal\t- 8");
                Console.ForegroundColor = ConsoleColor.Gray;
            }
            else
                Console.WriteLine("Octal\t- 8");
            Thread.Sleep(50);

            if (from == "DECIMAL")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Decimal\t - 10");
                Console.ForegroundColor = ConsoleColor.Gray;
            }
            else
                Console.WriteLine("Decimal\t - 10");
            Thread.Sleep(50);

            if (from == "HEXADECIMAL")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Hexadecimal\t- 16");
                Console.ForegroundColor = ConsoleColor.Gray;
            }
            else
                Console.WriteLine("Hexadecimal\t- 16");
            Thread.Sleep(50);

            if (from == "HEXAVIGESIMAL")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Hexavigesimal\t- 26");
                Console.ForegroundColor = ConsoleColor.Gray;
            }
            else
                Console.WriteLine("Hexavigesimal\t- 26");
            Thread.Sleep(50);

            if (from == "SEXAVIGESIMAL")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Sexagesimal\t- 60");
                Console.ForegroundColor = ConsoleColor.Gray;
            }
            else
                Console.WriteLine("Sexagesimal\t- 60");
            Thread.Sleep(50);

            Console.WriteLine();

            to = Console.ReadLine().ToUpper();

            Console.WriteLine();

            //---------------------------------------------------------------------------------------------
            //---------------------------------------------------------------------------------------------
            
            //---------------------------------------------------------------------------------------------
            //---------------------------------------------------------------------------------------------
            
            switch (to)
            {
                case "BINARY": //2
                    Console.WriteLine("Your choosen numbers in the {0} base, looks like this:", to);
                    binary = Convert.ToString(input, 2);
                    break;
                case "OCTAL": //8
                    Console.WriteLine("Your choosen numbers in the {0} base, looks like this:", to);
                    binary = Convert.ToString(input, 8);
                    break;
                case "DECIMAL": //10 - remove this or don't. I don't really care :P 
                    Console.WriteLine("but... this... is.... the base you entered the original number... but ok...");
                    Console.WriteLine("Your choosen numbers in the {0} base, looks like this:", to);
                    binary = Convert.ToString(input, 10);
                    break;
                case "HEXADECIMAL": //16
                    Console.WriteLine("Your choosen numbers in the {0} base, looks like this:", to);
                    binary = Convert.ToString(input, 16);
                    break;
                case "HEXAVIGESIMAL": //26
                    Console.WriteLine("Your choosen numbers in the {0} base, looks like this:", to);
                    binary = IntToString(input, Enumerable.Range('A', 26).Select(x => (char)x).ToArray());
                    break;
                case "SEXAGESIMAL": //60
                    Console.WriteLine("Your choosen numbers in the {0} base, looks like this:", to);
                    binary = IntToString(input,
                            new char[]
                            { '0','1','2','3','4','5','6','7','8','9',
                              'A','B','C','D','E','F','G','H','I','J','K','L','M','N','O','P','Q','R','S','T','U','V','W','X','Y','Z',
                              'a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x'});
                    break;
                default:
                    Console.WriteLine("something went wrong....");
                    break;
            }

            //---------------------------------------------------------------------------------------------
            //---------------------------------------------------------------------------------------------


            Console.WriteLine(binary);
            Console.ReadKey(true);
        }
        
        //-------------------------------------------------------------------------------------------------
        public static string IntToString(int input, char[] baseChars)
        {
            string result = string.Empty;
            int targetBase = baseChars.Length;

            do
            {
                result = baseChars[input % targetBase] + result;
                input = input / targetBase;
            }
            while (input > 0);

            return result;
        }
    }
}

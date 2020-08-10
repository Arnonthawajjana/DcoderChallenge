using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

//Compiler version 4.0, .NET Framework 4.5

namespace DcoderChallenge.Challenge.Easy
{
    //Challenge
    //https://code.dcoder.tech/challenges/57f2c800ba0d95f40dc9f007/binary-to-decimal
    public class E28_Binary_to_Decimal
    {
        public static void Main(string[] args)
        {
            int number = Convert.ToInt32(Console.ReadLine());
            if (-1000 > number || number > 1000)
                Console.WriteLine("Input Number Over flow");
            else
            {
                int value = 2;

                if (0 <= number && number <= 1000)
                    for (int counter = 0; counter <= number; counter++)
                        Printing(false, counter == number, value, counter);
                else if (0 > number && number >= -1000)
                    for (int counter = 0; counter >= number; counter--)
                        Printing(true, counter == number, value, counter);
            }
        }
        public static void Printing(bool isMinus, bool condition, int value, int counter)
        {
            //Key is here https://www.daveoncsharp.com/2009/09/formatting-decimals-in-csharp/
            Console.Write(isMinus ? Math.Pow(value, counter).ToString("0.0##########") : ((long)Math.Pow(value, counter)).ToString());
            if (!condition) Console.Write(",");
        }
    }
}
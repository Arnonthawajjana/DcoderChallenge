using System;
using System.Globalization;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

//Compiler version 4.0, .NET Framework 4.5

namespace DcoderChallenge.Challenge.Easy
{
    //Challenge
    //https://code.dcoder.tech/challenges/58164a8bba0d95f40dca6050/the-bit-flipper
    public class E31_The_Bit_Flipper
    {
        public static void Main(string[] args)
        {
            string inputBinaries = Console.ReadLine();
            {
                string Matches = "01";
                foreach (char c in inputBinaries)
                {
                    if (Matches.IndexOf(c) < 0)
                    {
                        Console.WriteLine($"WTF are you input {c} isn't binary");
                        break;
                    }
                    else
                        Console.Write((c == '0') ? '1' : '0');
                }
            }
        }

    }
}
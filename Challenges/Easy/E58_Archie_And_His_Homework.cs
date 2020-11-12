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
    //https://code.dcoder.tech/challenges/5b1e08f9098ec1fe237d243b/archie-and-his-homework
    public class E58_Archie_And_His_Homework
    {
        static void reduceFraction(int x, int y)
        {
            int d;
            d = __gcd(x, y);

            x = x / d;
            y = y / d;

            Console.WriteLine($"{x} {y}");
        }

        static int __gcd(int a, int b)  // Group common Divided
        {
            if (b == 0)
                return a;
            return __gcd(b, a % b);

        }

        public static void Main(string[] args)
        {
            int[] numeratorsAndDenominator = Array.ConvertAll(Console.ReadLine().Split(' ', StringSplitOptions.None), Convert.ToInt32);
            reduceFraction(numeratorsAndDenominator[0], numeratorsAndDenominator[1]);
        }
    }
}
using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

//Compiler version 4.0, .NET Framework 4.5

namespace DcoderChallenge.Challenge.Easy
{
    //Challenge
    //https://code.dcoder.tech/challenges/580601a9ba0d95f40dca3067/the-floating-circle
    public class E29_The_Floating_Circle
    {
        protected static readonly float PI = 3.14f;
        public static void Main(string[] args)
        {
            float inputRadius = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture.NumberFormat);
            if(-1000f > inputRadius || inputRadius > 1000f)
                Console.WriteLine("Overflow");
            else if (0 >= inputRadius)
                Console.WriteLine("0");
            else
            {
                //https://docs.microsoft.com/en-us/dotnet/standard/base-types/standard-numeric-format-strings?redirectedfrom=MSDN
                Console.WriteLine("{0:F2}",(PI*Math.Pow(inputRadius,2)));
            }
        }

    }
}
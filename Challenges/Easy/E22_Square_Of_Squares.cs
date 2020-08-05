using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

//Compiler version 4.0, .NET Framework 4.5

namespace DcoderChallenge.Challenge.Easy
{
    //Challenge
    //https://code.dcoder.tech/challenges/57dd532aa0436fde35f545aa/square-of-squares
    public class E22_Square_Of_Squares
    {
        public static void Main(string[] args)
        {
            int inputSqr = Int32.Parse(Console.ReadLine());
            Double result = Math.Sqrt(inputSqr);
            Console.WriteLine( result == Math.Truncate(result) ? "YES" : "NO");
        }
    }
}
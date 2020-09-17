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
    //https://code.dcoder.tech/challenges/5b2126feac71d7305eae79bf/ceil-and-floor

    public class E47_Ceil_And_Floor
    {
        public static void Main(string[] args)
        {
            float input = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine($"{Math.Ceiling(input)} {Math.Floor(input)}");
        }
    }
}
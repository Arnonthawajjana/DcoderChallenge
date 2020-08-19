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
    //https://code.dcoder.tech/challenges/58263370a153276059495787/the-coding-challenges
    public class E32_The_Coding_Challenges
    {
        public static void Main(string[] args)
        {
            //Your code goes here
            //Use this Formula to solve the problem N = n(n-1) ;
            int teamNumbers = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(teamNumbers*(teamNumbers-1));
        }

    }
}
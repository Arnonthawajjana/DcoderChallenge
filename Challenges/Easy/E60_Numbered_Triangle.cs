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
    //https://code.dcoder.tech/challenges/5b55730fab46cd2f99d3bf80/numbered-triangle
    public class E60_Numbered_Triangle
    {

        public static void Main(string[] args)
        {
            int highNumber = Convert.ToInt32(Console.ReadLine());
            if(1 > highNumber || highNumber > 9)
                Console.WriteLine("Over hight 1 ≤ N ≤ 9");
            else{
                for(int i = 1; i <= highNumber; i++)
                {
                    for(int j = 1; j <= i; j++)
                        Console.Write(j + 1 > i ? $"{j}" : $"{j} ");
                    Console.WriteLine();
                }

            }
        }
    }
}
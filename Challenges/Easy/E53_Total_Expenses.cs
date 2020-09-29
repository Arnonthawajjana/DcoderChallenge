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
    //https://code.dcoder.tech/challenges/5b2134b1ac71d7305eae7a0d/total-expenses
    public class E53_Total_Expenses
    {
        public static void Main(string[] args)
        {
            int numberTestCase = Convert.ToInt32(Console.ReadLine());
            if(1 > numberTestCase || numberTestCase > 100)
                Console.WriteLine("Over case");
            else{
                for(int i = 0; i < numberTestCase; i++)
                {
                    float input = Convert.ToSingle(Console.ReadLine());
                    if(1F > input || input > 100000F) break;
                    Console.WriteLine(input > 1000 ? (input - (input*0.10)).ToString("0.00##########") : input.ToString("0.00##########"));
                }
            }
        }
    }
}
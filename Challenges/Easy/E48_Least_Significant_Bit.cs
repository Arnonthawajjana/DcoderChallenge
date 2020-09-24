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
    //https://code.dcoder.tech/challenges/5b212cafac71d7305eae79e6/least-significant-bit

    public class E48_Least_Significant_Bit
    {
        public static bool IsEven(int number) => ((number & 1) != 1);
        public static void Main(string[] args)
        {
            //https://www.geeksforgeeks.org/check-if-a-number-is-odd-or-even-using-bitwise-operators/
            int inputNumberOfTestCase = Convert.ToInt32(Console.ReadLine());
            if(1 > inputNumberOfTestCase || inputNumberOfTestCase > 100)
                Console.WriteLine("Something's Wrong with it");
            else{
                int inputCase = 0;
                for(int i = 0; i < inputNumberOfTestCase; i++)
                {
                    inputCase = Convert.ToInt32(Console.ReadLine());
                    if(1 > inputCase || inputCase > 1000) i--;
                    else Console.WriteLine(IsEven(inputCase) == true ? "No" : "Yes");
                }
            }
        }
    }
}
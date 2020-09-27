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
    //https://code.dcoder.tech/challenges/5b2899ce0abe8c533c02514d/first-and-the-last-digit
    public class E51_First_And_The_Last_Digit
    {
        public static void Main(string[] args)
        {
            int testCaseNumber = Convert.ToInt32(Console.ReadLine());
            if(1 > testCaseNumber || testCaseNumber > 100)
                Console.WriteLine("fail test case");
            else{
                int result = 0;
                for(int i = 0; i < testCaseNumber; i++)
                {
                    string number = Console.ReadLine();
                    int item = Convert.ToInt32(number);
                    if(10 > Convert.ToInt32(number) || Convert.ToInt32(number) > 100000) break;
                    result = Convert.ToInt32(number[0].ToString()) + Convert.ToInt32(number[number.Length-1].ToString());
                    Console.WriteLine(result);
                }
            }
        }
    }
}
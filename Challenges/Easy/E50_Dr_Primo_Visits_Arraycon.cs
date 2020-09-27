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
    //https://code.dcoder.tech/challenges/5b2262e2c634619570de1efa/dr-primo-visits-arraycon
    public class E50_Dr_Primo_Visits_Arraycon
    {
        public static bool isPrime(int number)
        {

            if (number == 1) return false;
            if (number == 2) return true;

            var limit = Math.Ceiling(Math.Sqrt(number));
            for (int i = 2; i <= limit; ++i)  {
                if (number % i == 0)  return false;
            }

            return true;
        }
        public static void Main(string[] args)
        {
            int maxlength = Convert.ToInt32(Console.ReadLine());
            if(1 > maxlength || maxlength > 1000)
                Console.WriteLine("Over Test Case");
            else{
                int[] testCases = Array.ConvertAll(Console.ReadLine().Split(' ', StringSplitOptions.None),Convert.ToInt32);
                if(testCases.Length != maxlength)
                    Console.WriteLine("What you done there bitch");
                else{
                    int result = 0;
                    foreach(int item in testCases)
                    {
                        if(isPrime(item)) result++;
                    }
                    Console.WriteLine($"{result}");
                }
            }
        }
    }
}
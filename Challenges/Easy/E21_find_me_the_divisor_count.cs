using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

//Compiler version 4.0, .NET Framework 4.5

namespace DcoderChallenge.Challenge.Easy
{
    //Challenge
    //https://code.dcoder.tech/challenges/57d84966a61b30057bce681c/find-me-the-divisor-count
    public class E21_find_me_the_divisor_count
    {
        public static void Main(string[] args)
        {
            int[] inputnumber = Array.ConvertAll(Console.ReadLine().Split(" ", StringSplitOptions.None), Convert.ToInt32);
            if (inputnumber.Length > 3 || inputnumber.Any(x => (1 > x || x > 1000)))
                Console.WriteLine("Oh God something Wrong");
            else
            {
                int count = 0;
                int multiply = Math.DivRem(inputnumber[0], inputnumber[2], out int remain);
                multiply = remain < 1 ? multiply : multiply + 1;
                while ((multiply * inputnumber[2]) <= inputnumber[1])
                {
                    count++; multiply++;
                }
                Console.WriteLine(count);
            }
        }
    }
}
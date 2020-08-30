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
    //https://code.dcoder.tech/challenges/5b191e3abe95b1e16447882e/help-cody

    public class E39_Help_Cody
    {
        public static void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine());
            if (2 > N || N > 50) Console.WriteLine("Length is Over");
            else
            {
                int[] insert = Array.ConvertAll(Console.ReadLine().Split(' ', StringSplitOptions.None), Convert.ToInt32);
                if (insert.Length != N) Console.WriteLine("FAIL");
                else
                {
                    Array.Sort(insert);
                    Array.Reverse(insert);
                    for (int i = 0; i < N; i++)
                    {
                        if (-1000 > insert[i] || insert[i] > 1000) break;
                        Console.Write(insert[i]);
                        if (i < N - 1) Console.Write(" ");
                    }
                }
            }
        }
    }
}
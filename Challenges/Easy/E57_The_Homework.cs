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
    //https://code.dcoder.tech/challenges/5b2ea2ffa5c3787cda197f5a/the-homework
    public class E57_The_Homework
    {
        public static bool ValidateRange(int valueInput, int maxrange)
        {
            return (1 > valueInput || valueInput > maxrange);
        }
        public static void Main(string[] args)
        {
            int testCasesNumber = Convert.ToInt32(Console.ReadLine());
            if(ValidateRange(testCasesNumber, 100))
                Console.WriteLine("Breached the limit 1<=T<=100");
            else{
                for(int i = 0; i < testCasesNumber; i++)
                {
                    int maxNumber = Convert.ToInt32(Console.ReadLine());
                    if(ValidateRange(maxNumber, 100))
                        Console.WriteLine("Breached the limit 1<=K<=100");
                    else{
                        int[] speratedIntegers = Array.ConvertAll(Console.ReadLine().Split(' ', StringSplitOptions.None), Convert.ToInt32);
                        Array.Sort(speratedIntegers);
                        if(speratedIntegers.Length != maxNumber || ValidateRange(speratedIntegers[maxNumber-1], 9) )
                        {
                            Console.WriteLine("Numbers not satified maxnumber your need Or some digit not in 0 - 9");
                            i--;
                        }
                        else{
                            for(int j = maxNumber-1; j >= 0; j--)
                                Console.Write(speratedIntegers[j]);
                        }
                        Console.Write("\n");
                    }
                }
            }
        }
    }
}
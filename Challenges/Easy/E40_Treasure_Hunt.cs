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
    //https://code.dcoder.tech/challenges/5b192072a2e6485077c2b42d/treasure-hunt

    public class E40_Treasure_Hunt
    {
        public static bool ValidatedArray (int[] itemArray) => itemArray.Length != 2;
        public static bool ValidatedValue (int item) => 1 > item || item > 1000;
        public static void Main(string[] args)
        {
            int value1, weight1, value2, weight2, result;
            int maxW = Convert.ToInt32(Console.ReadLine());
            int[] items1 = Array.ConvertAll(Console.ReadLine().Split(' ', StringSplitOptions.None), Convert.ToInt32);
            int[] items2 = Array.ConvertAll(Console.ReadLine().Split(' ', StringSplitOptions.None), Convert.ToInt32);
            if(ValidatedArray(items1) || ValidatedArray(items2))
                Console.WriteLine("Put items wrong");
            else{
                if(ValidatedValue(maxW) || ValidatedValue(items1[0]) || ValidatedValue(items1[1]) || ValidatedValue(items2[0]) || ValidatedValue(items2[1]) )
                    Console.WriteLine("Some value your input over 1<=X<=1000");
                else{
                    value1 = items1[0];
                    weight1 = items1[1];
                    value2 = items2[0];
                    weight2 = items2[1];

                    if(maxW < weight1 && maxW < weight2) result = 0;
                    else if(maxW > weight1 && maxW > weight2){
                        if(maxW >= weight1 + weight1) result = value1 + value2;
                        else result = value1 > value2 ? value1 : value2;
                    }
                    else{
                        result = weight1 < maxW ? value1 : value2;
                    }
                    Console.WriteLine(result);

                }

            }
        }
    }
}
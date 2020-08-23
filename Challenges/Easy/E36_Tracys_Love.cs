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
    //https://code.dcoder.tech/challenges/58aa0615e57b49d25a76ca7e/tracys-love

    public class E36_Tracys_Love
    {
        public static void Main(string[] args)
        {
            int[] twoIntegers = Array.ConvertAll(Console.ReadLine().Split(' ',StringSplitOptions.None),Convert.ToInt32);
            if(twoIntegers.Length != 2)
                Console.WriteLine("Insert 2 again");
            else
            {
                if(0 > twoIntegers[0] || twoIntegers[0] > 10 || 0 > twoIntegers[1] || twoIntegers[1] > 10)
                    Console.WriteLine("a and b 0 to 10");
                else{
                    int result1 = 0;
                    int result2 = 0;
                    result1 = twoIntegers[0] > twoIntegers[1] ? twoIntegers[0] - twoIntegers[1] : twoIntegers[1] - twoIntegers[0];
                    result2 = twoIntegers[0] + twoIntegers[1];
                    Console.WriteLine( (result1 == 6 || result2 == 6) ? "Love" : "Hate");

                }
            }
        }

    }
}
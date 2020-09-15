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
    //https://code.dcoder.tech/challenges/5b1e0ad0dcb043933f06c7b8/ordinal-representation

    public class E44_Ordinal_Representation
    {
        public static void Main(string[] args)
        {
            int inputToOrdinal = Convert.ToInt32(Console.ReadLine());
            if(1 > inputToOrdinal || inputToOrdinal > 9)
                Console.WriteLine("Put wrong numbers");
            else{
                Console.WriteLine(inputToOrdinal == 1? "1st" : inputToOrdinal == 2? "2nd" : inputToOrdinal == 3? "3rd" : $"{inputToOrdinal}th");
            }
        }
    }
}
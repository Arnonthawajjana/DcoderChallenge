using System;
using System.Globalization;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

//Compiler version 4.0, .NET Framework 4.5

namespace DcoderChallenge.Challenge.Easy
{
    //Challenge
    //https://code.dcoder.tech/challenges/5e1086efa1312802b296d39f/floating-number
    public class E76_Floating_Number
    {
        public static void Main(string[] args)
        {
            int testCases = Convert.ToInt32(Console.ReadLine());
            if(1 > testCases || testCases > 1000) Console.WriteLine("Hey Bro something went wrong");
            else{
                var floatNumber = new List<decimal>();
                for(int i = 0; i < testCases;  i++)
                {
                    floatNumber.Add(Convert.ToDecimal(Console.ReadLine()));
                }
                foreach(decimal data in floatNumber)
                    Console.WriteLine(Math.Round(data, 2, MidpointRounding.ToEven));
            }
        }
    }
}
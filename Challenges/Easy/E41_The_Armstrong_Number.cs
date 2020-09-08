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
    //https://code.dcoder.tech/challenges/5b1b76608c7f54cf188ed87d/the-armstrong-number

    public class E41_The_Armstrong_Number
    {
        public static void Main(string[] args)
        {
            int input = Convert.ToInt32(Console.ReadLine());
            int inputTemp = input;
            int temp = 0;
            int result = 0;
            while(inputTemp > 0)
            {
                temp = inputTemp%10;
                result += temp*temp*temp;
                inputTemp = inputTemp/10;
            }
            Console.WriteLine(input == result ? "YES" : "NO");
        }
    }
}
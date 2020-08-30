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
    //https://code.dcoder.tech/challenges/58f13ab20fb669f37e957255/tables

    public class E38_Tables
    {
        public static void Main(string[] args)
        {
            int number = Convert.ToInt32(Console.ReadLine());
            if(0 > number || number > 10000) Console.WriteLine("Over limit");
            else
                for(int i = 1; i <= 10; i++)
                    Console.WriteLine(i*number);
        }
    }
}
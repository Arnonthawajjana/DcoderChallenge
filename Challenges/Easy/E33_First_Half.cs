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
    //https://code.dcoder.tech/challenges/5840853531b845750364b612/first-half
    public class E33_First_Half
    {
        public static void Main(string[] args)
        {
            String inputText = Console.ReadLine();
            if(String.IsNullOrEmpty(inputText) || inputText.Length > 100)
                Console.WriteLine("Input some or Input too much text.");
            else
                Console.WriteLine(inputText.Substring(0, inputText.Length/2));
        }

    }
}
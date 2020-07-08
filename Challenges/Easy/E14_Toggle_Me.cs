using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Math;

//Compiler version 4.0, .NET Framework 4.5

namespace DcoderChallenge.Challenge.Easy
{
    //Challenge
    //https://code.dcoder.tech/challenges/57c033b97b6a33c622e8de73/they-see-me-palindroming
    public class E14_Toggle_Me
    {
        public static void Main(string[] args)
        {
            string inputText = Console.ReadLine();
            if(String.IsNullOrEmpty(inputText) || inputText.Length > 15)
                Console.WriteLine("Some String is not Enough Or over 15");
            else
            {
                var result = new StringBuilder();
                foreach(char item in inputText)
                {
                    result.Append(Char.IsLower(item) ? Char.ToUpper(item) : Char.ToLower(item));
                }
                Console.WriteLine(result);
            }

        }

    }
}
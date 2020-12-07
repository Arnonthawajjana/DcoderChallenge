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
    //https://code.dcoder.tech/challenges/5b5d34ec61601549b1d0b1e9/finding-nemo
    public class E65_Finding_Nemo
    {
        public static void Main(string[] args)
        {
            int numberOfWords = Convert.ToInt32(Console.ReadLine());
            string[] words = Array.ConvertAll(Console.ReadLine().Split(' ', StringSplitOptions.None), Convert.ToString);
            if(words.Length != numberOfWords)
                Console.WriteLine("Are you serious bitches????");
            else
            {
                int i,result = 0;
                for(i = 0; i < numberOfWords; i++)
                {
                    if(words[i].Equals("Nemo", StringComparison.CurrentCultureIgnoreCase))
                    {
                        result = i+1;
                        break;
                    }
                }
                Console.WriteLine(result);
            }
        }
    }
}
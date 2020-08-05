using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

//Compiler version 4.0, .NET Framework 4.5

namespace DcoderChallenge.Challenge.Easy
{
    //Challenge
    //https://code.dcoder.tech/challenges/57cea7cb7b6a33c622e8f12d/the-vowel-counter
    public class E20_The_Vowel_Counter
    {
        public static void Main(string[] args)
        {
            var validateValues = "aeiou";
            string InputText = Console.ReadLine();
            if (String.IsNullOrEmpty(InputText) || InputText.Length > 1000)
                Console.WriteLine("You should input something");
            else
            {
                int count = 0;
                foreach (var charactor in InputText)
                {
                    if (validateValues.IndexOf((Char.IsLower(charactor) ? charactor : Char.ToLower(charactor))) > -1)
                        count++;
                }
                Console.WriteLine(count);
            }
        }
    }
}
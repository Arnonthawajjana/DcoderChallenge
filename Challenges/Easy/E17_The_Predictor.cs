using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

//Compiler version 4.0, .NET Framework 4.5

namespace DcoderChallenge.Challenge.Easy
{
    //Challenge
    //https://code.dcoder.tech/challenges/57c8a4577b6a33c622e8e744/the-predictor
    public class E17_The_Predictor
    {
        public static void Main(string[] args)
        {
            string inputBinaries = Console.ReadLine();
            if (1 > inputBinaries.Length || inputBinaries.Length > 10000)
                Console.WriteLine(" require binary atleast 1 digit and not over 10000");
            else
            {
                string Matches = "01";
                int countConsucutive = 0;
                char currentConsucutive = '0';
                foreach (char c in inputBinaries)
                {
                    if (countConsucutive == 6) break;
                    if (Matches.IndexOf(c) < 0)
                    {
                        Console.WriteLine($"WTF are you input {c} isn't binary");
                        break;
                    }
                    if (c == currentConsucutive) countConsucutive++;
                    else { countConsucutive = 1; currentConsucutive = (currentConsucutive == '0') ? '1' : '0'; }
                }
                Console.WriteLine(countConsucutive < 6 ? "Good" : "Bad");
            }
        }
    }
}
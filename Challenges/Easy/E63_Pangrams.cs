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
    //https://code.dcoder.tech/challenges/5b894d46a93aaa7ff73be00a/pangrams
    public class E63_Pangrams
    {
        public static void Main(string[] args)
        {
            string wordscheck = Console.ReadLine();
            if(wordscheck.Length < 26)
                Console.WriteLine("Seriously?????");
            else{
                bool IsPangram = true;
                bool[] usingAlphabet = new bool[26];
                for(int i = 0; i < wordscheck.Length;i++)
                {
                    if(Char.IsLetter(wordscheck[i]))
                        usingAlphabet[ Char.IsLower(wordscheck[i]) ? wordscheck[i] - 'a' : wordscheck[i] - 'A'] = true;
                }
                foreach(bool IsUsed in usingAlphabet)
                {
                    if(IsUsed == false)
                    {
                        IsPangram = false;
                        break;
                    }
                }
                Console.WriteLine(IsPangram ? "YES" : "NO");
            }
        }
    }
}
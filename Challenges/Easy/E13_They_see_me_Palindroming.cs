using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using static System.Math;

//Compiler version 4.0, .NET Framework 4.5

namespace DcoderChallenge.Challenge.Easy
{
    //Challenge
    //https://code.dcoder.tech/challenges/57c033b97b6a33c622e8de73/they-see-me-palindroming
    public class E13_They_see_me_Palindroming
    {
        //What I search for
        //https://stackoverflow.com/questions/1181419/verifying-that-a-string-contains-only-letters-in-c-sharp
        //https://stackoverflow.com/questions/9790749/check-if-a-string-is-a-palindrome
        public static void Main(string[] args)
        {
        string inputText = Console.ReadLine();
        if(!inputText.All(Char.IsLetter) || String.IsNullOrEmpty(inputText))
            Console.WriteLine("Some character isn't a letter.");
        else
            Console.WriteLine(Palindroming(inputText) == true ? "Yes": "No");
        }

        public static bool Palindroming(string inputText)
        {
            bool result = false;
            for(int i = 0,j = inputText.Length - 1 ; i < inputText.Length; i++,j-- )
            {
                result = inputText[i] == inputText[j];
                if(result == false) break;
            }
            return result;

            //real answer should be like this.
            //return myString.SequenceEqual(myString.Reverse());
        }
    }
}
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
    //https://code.dcoder.tech/challenges/5b5de77461601549b1d0b570/extraction-of-numbers
    public class E64_Extraction_Of_Numbers
    {
        public static void Main(string[] args)
        {
            int wordsCount = Convert.ToInt32(Console.ReadLine());
            string[] words = Array.ConvertAll(Console.ReadLine().Split(' ', StringSplitOptions.None), Convert.ToString);
            if(words.Length != wordsCount || (1 > wordsCount || wordsCount > 50) )
                Console.WriteLine("WHAT!!!!!");
            else{
                List<int> results = new List<int>();
                foreach(string word in words)
                    foreach(char charactor in word)
                        if(Char.IsNumber(charactor))
                            results.Add(Int32.Parse(charactor.ToString()));

                for(int i = 0 ; i < results.Count; i++)
                    Console.Write((i+1) == results.Count? $"{results[i]}"  : $"{results[i]} ");
            }

        }
    }
}
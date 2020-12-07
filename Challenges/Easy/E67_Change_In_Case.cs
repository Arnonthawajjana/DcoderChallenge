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
    //https://code.dcoder.tech/challenges/5b6db8d865139d414b2a656e/change-in-case
    public class E67_Change_In_Case
    {
        public static void Main(string[] args)
        {
            int countAlphabets = Convert.ToInt32(Console.ReadLine());
            if(1 > countAlphabets || countAlphabets > 40)
                Console.WriteLine("length too much");
            else{


                char[] text = Console.ReadLine().ToCharArray();
                if(text.Length != countAlphabets)
                    Console.WriteLine("alphabet and texts size not match");
                else{
                    int[] convertCaseIndexing = Array.ConvertAll(Console.ReadLine().Split(' ', StringSplitOptions.None), Convert.ToInt32);
                    text[convertCaseIndexing[0]] = Char.IsUpper(text[convertCaseIndexing[0]])? Char.ToLower(text[convertCaseIndexing[0]]) : Char.ToUpper(text[convertCaseIndexing[0]]);
                    text[convertCaseIndexing[1]] = Char.IsUpper(text[convertCaseIndexing[1]])? Char.ToLower(text[convertCaseIndexing[1]]) : Char.ToUpper(text[convertCaseIndexing[1]]);
                    Console.WriteLine(string.Join("",text));
                }


            }
        }
    }
}
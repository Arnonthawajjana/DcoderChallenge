using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

//Compiler version 4.0, .NET Framework 4.5

namespace DcoderChallenge.Challenge.Easy
{
    //Challenge
    //https://code.dcoder.tech/challenges/57e22feaa0436fde35f55228/capitalize-me
    public class E23_Capitalize_Me
    {
        public static void Main(string[] args)
        {
            string inputText = Console.ReadLine();
            if(1 >inputText.Length || inputText.Length > 1000) Console.WriteLine("Text Length Exceed limited");
            else{
                String[] splitedText = inputText.Split (' ', StringSplitOptions.RemoveEmptyEntries);
                for(int i = 0 ; i < splitedText.Length ; i++)
                {
                    Console.Write(splitedText[i].Substring(0, 1) . ToUpper()+splitedText[i].Substring(1));
                    if(i == splitedText.Length - 1) break;
                    Console.Write(" ");
                }
            }
        }
    }
}
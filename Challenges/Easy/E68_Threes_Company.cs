using System;
using System.Globalization;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

//Compiler version 4.0, .NET Framework 4.5

namespace DcoderChallenge.Challenge.Easy
{
    //Challenge
    //https://code.dcoder.tech/challenges/5b6e530365139d414b2a683e/threes-company
    public class E68_Threes_Company
    {
        public static void Main(string[] args)
        {
            int letternumber = Convert.ToInt32(Console.ReadLine());
            if(1 > letternumber || letternumber >20)
                Console.WriteLine("Over limit");
            else{
                string text = Console.ReadLine();
                if(letternumber != text.Length)
                    Console.WriteLine("String Size mismatched");
                else{
                    StringBuilder textCreator = new StringBuilder();
                    foreach(char charr in text)
                        textCreator.Append(new String(charr, 3));
                    Console.WriteLine(textCreator.ToString());
                }
            }
        }
    }
}
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
    //https://code.dcoder.tech/challenges/5b211869ac71d7305eae7965/string-matching
    public class E74_String_Matching
    {
        public static void Main(string[] args)
        {
            int rounds = Convert.ToInt32(Console.ReadLine());
            if(1 > rounds || rounds > 10) Console.WriteLine("WHAT is over limit");
            else{
                var listCheck = new List<string[]>();
                for(int i = 0; i < rounds; i++)
                {
                    listCheck.Add(Console.ReadLine().Split(" ", StringSplitOptions.None));
                }

                foreach(string[] temp in listCheck)
                {
                    if(1 > temp[0].Length || temp[0].Length > 100)
                    {
                        Console.WriteLine("What's going on!!!");
                        break;
                    }
                    else{
                        Console.WriteLine(temp[0].Contains(temp[1]) ? "Yes" : "No");
                    }
                }

            }
        }
    }
}
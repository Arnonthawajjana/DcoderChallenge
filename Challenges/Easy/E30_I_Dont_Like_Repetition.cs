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
    //https://code.dcoder.tech/challenges/580e3789ba0d95f40dca4ab5/i-dont-like-repetition
    public class E30_I_Dont_Like_Repetition
    {
        public static void Main(string[] args)
        {
            string inputString = Console.ReadLine();
            if( String.IsNullOrEmpty(inputString) || inputString.Length > 100)
                Console.WriteLine("Somwthing wrong with it");
            else
            {
                ArrayList aL = new ArrayList();
                foreach(char cha in inputString)
                    if(!aL.Contains(cha))
                        aL.Add(cha);
                //https://www.tutorialsteacher.com/csharp/csharp-arraylist
                foreach(char cha in aL)
                    Console.Write(cha);
            }
        }

    }
}
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
    //https://code.dcoder.tech/challenges/5b2e9f66a5c3787cda197f51/text-editor
    public class E59_Text_Editor
    {

        public static void Main(string[] args)
        {
            int testCases = Convert.ToInt32(Console.ReadLine());
            if(1 > testCases || testCases > 100)
                Console.WriteLine("Over number 1<=T<=100 ");
            else{
                for(int i = 0; i < testCases; i++)
                {
                    Console.WriteLine(Console.ReadLine().ToUpper());
                }
            }
        }
    }
}
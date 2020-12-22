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
    //https://code.dcoder.tech/challenges/5b5ee71361601549b1d0b92b/happy-string
    public class E70_Happy_String
    {
        public static void Main(string[] args)
        {
            // K = length;
            // S = [z...a];
            int length = Convert.ToInt32(Console.ReadLine());
            if(1 > length || length > 26) Console.WriteLine("Fuck Sake Overlimit");
            else{
                //
                StringBuilder text = new StringBuilder();

                int indexAsciiPointer = 96;
                for(int current = indexAsciiPointer+length ; current > indexAsciiPointer; current--)
                    text.Append(Convert.ToChar(current));

                Console.WriteLine(text);
            }
        }
    }
}
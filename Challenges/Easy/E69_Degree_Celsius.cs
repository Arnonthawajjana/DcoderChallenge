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
    //https://code.dcoder.tech/challenges/5b2ecdfea5c3787cda197fde/degree-celsius
    public class E69_Degree_Celsius
    {
        public static void Main(string[] args)
        {
            //°C to °F	Divide by 5, then multiply by 9, then add 32
            //°F to °C	Deduct 32, then multiply by 5, then divide by 9
            int temperatureCelsius = Convert.ToInt32(Console.ReadLine());
            if(0 > temperatureCelsius || temperatureCelsius > 1000) Console.WriteLine("Overlimit Temperature");
            else Console.WriteLine( (int)( ((temperatureCelsius/5)*9) + 32));
        }
    }
}
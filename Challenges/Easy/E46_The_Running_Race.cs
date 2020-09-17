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
    //https://code.dcoder.tech/challenges/5b211c4cac71d7305eae7980/the-running-race

    public class E46_The_Running_Race
    {
        public static bool ValidateInput(int valueCheck)
        {
            return 1> valueCheck || valueCheck > 100;
        }

        public static void Main(string[] args)
        {
            int[] raceCompete = Array.ConvertAll(Console.ReadLine().Split(' ', StringSplitOptions.None), Convert.ToInt32);
            if(ValidateInput(raceCompete[0]) || ValidateInput(raceCompete[1]) || ValidateInput(raceCompete[2]))
                Console.WriteLine("Some Value is over 1<X<100");
            else{
                Console.WriteLine(raceCompete[1] > raceCompete[2] ? "Alex" : raceCompete[1] < raceCompete[2] ? "Ryan" : "Draw");
            }
        }
    }
}
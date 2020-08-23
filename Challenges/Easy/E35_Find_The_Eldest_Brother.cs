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
    //https://code.dcoder.tech/challenges/587e0f234ab96f5e3ee7477e/find-the-eldest-brother

    public class E35_Find_The_Eldest_Brother
    {
        public static void Main(string[] args)
        {
            int[] ageOf5Brothers = Array.ConvertAll(Console.ReadLine().Split(' ', StringSplitOptions.None), Convert.ToInt32);
            if(ageOf5Brothers.Length != 5)
                Console.WriteLine("Input 5 number for each brothers again plz");
            else{
                int elsdestAge = 0;
                foreach(var ageofbrother in ageOf5Brothers)
                {
                    if(ageofbrother > elsdestAge) elsdestAge = ageofbrother;
                    if(1 > ageofbrother || ageofbrother > 100)
                    {
                        elsdestAge = -1;
                        break;
                    }
                }
                Console.WriteLine(elsdestAge);
            }
        }

    }
}
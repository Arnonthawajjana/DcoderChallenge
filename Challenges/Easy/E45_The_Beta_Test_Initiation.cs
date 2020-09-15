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
    //https://code.dcoder.tech/challenges/5b1e0ad0dcb043933f06c7b8/ordinal-representation

    public class E45_The_Beta_Test_Initiation
    {
        public static void Main(string[] args)
        {
            string[] inputVersionAndroids = Console.ReadLine().Split(" ",StringSplitOptions.None);
            if(inputVersionAndroids.Length != 2)
                Console.WriteLine("We need 2 numbers");
            else{
                float[] VersionAndroids = Array.ConvertAll(inputVersionAndroids, Convert.ToSingle);
                if(1 > VersionAndroids[0] || VersionAndroids[1] > 6)
                    Console.WriteLine("WTF InsertWrong Number");
                else{
                    Console.WriteLine(VersionAndroids[0] <= VersionAndroids[1] ? "Yes" : "No");
                }
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

//Compiler version 4.0, .NET Framework 4.5

namespace DcoderChallenge.Challenge.Easy
{
    //Challenge
    //https://code.dcoder.tech/challenges/57ea546514d5a63a027f317b/the-secure-function--xr
    public class E26_The_Secure_Function_XR
    {
        public static void Main(string[] args)
        {
            int inputinteger = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(inputinteger % 7);
        }
    }
}
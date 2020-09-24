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
    //https://code.dcoder.tech/challenges/5b213640ac71d7305eae7a14/valid-quadrilateral
    //Partial Sovled
    public class E49_Valid_Quadrilateral
    {
        public static bool ValidateInputArray(int[] arraySides)
        {
            bool result = true;
            foreach(int casenum in arraySides)
            {
                if(1 > casenum || casenum > 360) {result = false; break;}
            }
            return result;
        }
        public static void Main(string[] args)
        {
            int numberOfTestCase = Convert.ToInt32(Console.ReadLine());
            if(1 > numberOfTestCase || numberOfTestCase > 100) Console.WriteLine("Over Test Cases");
            else{
                for(int i = 0; i < numberOfTestCase; i++)
                {
                    int[] caseSum = Array.ConvertAll(Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries), Convert.ToInt32);

                    Console.WriteLine(caseSum.Length == 4 && ValidateInputArray(caseSum) && caseSum.Sum() == 360 ? "YES" : "NO");
                }
            }
        }
    }
}
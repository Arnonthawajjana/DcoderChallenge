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
    //https://code.dcoder.tech/challenges/5b1bd39cd9432b981bd826e2/buy-the-bundle

    public class E42_Buy_The_Bundle
    {
        public static void Main(string[] args)
        {
            int testCasesNumber = Convert.ToInt32(Console.ReadLine());
            if(1> testCasesNumber || testCasesNumber > 20)
                Console.WriteLine("Over limit test cases");
            else{
                var items = new List<Tuple<int, int>>();
                for(int i = 0; i < testCasesNumber; i++)
                {
                    int[] testcase = Array.ConvertAll(Console.ReadLine().Split(" ",StringSplitOptions.None),Convert.ToInt32);
                    if(testcase.Length != 2 || (1 > testcase[0] || testcase[0] > 100 || 1 > testcase[1] || testcase[1] > 100000 ))
                    {
                        Console.WriteLine("Some test case is over then fail all");
                        break;
                    }
                    items.Add(new Tuple<int, int>(testcase[0], testcase[1]) );
                }
                if(items.Count != testCasesNumber)
                    Console.WriteLine("Good bye can't be success due to not enough filled.");
                else
                    foreach(var caseItem in items)
                    {
                        Console.WriteLine(caseItem.Item2 % caseItem.Item1 == 0 ? "Yes" : "No");
                    }
            }
        }
    }
}
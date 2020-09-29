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
    //https://code.dcoder.tech/challenges/5b289c180abe8c533c025156/grade-the-students
    public class E52_Grade_The_Students
    {
        public static void Main(string[] args)
        {
            int testCaseCount = Convert.ToInt32(Console.ReadLine());
            if(1 > testCaseCount || testCaseCount > 10)
                Console.WriteLine("Over Number On TestCase");
            else{
                for(int i = 0; i < testCaseCount; i++)
                {
                    int[] input = Array.ConvertAll(Console.ReadLine().Split(' ', StringSplitOptions.None), Convert.ToInt32);
                    if(input.Length != 2 || (1 > input[0] || input[0] >100) || (1 > input[1] || input[1] >100))
                        Console.WriteLine("Sorry Conditional value not succeed");
                    else{
                        Console.WriteLine((input[0]> 70) &&(input[1] > 50) ? "Pass" : "Fail");
                    }
                }
            }
        }
    }
}
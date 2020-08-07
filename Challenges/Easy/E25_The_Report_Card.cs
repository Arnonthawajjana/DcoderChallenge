using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

//Compiler version 4.0, .NET Framework 4.5

namespace DcoderChallenge.Challenge.Easy
{
    //Challenge
    //https://code.dcoder.tech/challenges/57e6ba2312a1bda745dee267/the-report-card
    public class E25_The_Report_Card
    {
        public static void Main(string[] args)
        {
            int[] inputText = Array.ConvertAll(Console.ReadLine().Split(' ', StringSplitOptions.None), Convert.ToInt32);
            if(inputText.Any(x => 1 > x || x > 100 ))
                Console.WriteLine("Something Wrong with your input");
            else{
                char Result = 'Z';
                double allGrade = inputText.Average();
                    if (allGrade > 90 && allGrade <= 100)
                        Result = 'A';
                    else if (allGrade > 80 && allGrade <= 90)
                        Result = 'B';
                    else if (allGrade > 70 && allGrade <= 80)
                        Result = 'C';
                    else if (allGrade > 60 && allGrade <= 70)
                        Result = 'D';
                    else
                        Result = 'F';

                Console.WriteLine(Result);
            }
        }
    }
}
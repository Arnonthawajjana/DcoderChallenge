using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

//Compiler version 4.0, .NET Framework 4.5

namespace DcoderChallenge.Challenge.Easy
{
    //Challenge
    //https://code.dcoder.tech/challenges/57acd1861e1ff69730eda7f0/sum-of-squares
  public class E06_Sum_of_Squares
  {
    public static void Main(string[] args)
    {
        int[] inputnumber = Array.ConvertAll(Console.ReadLine().Split(" ",StringSplitOptions.None), Convert.ToInt32);
        if((1 > inputnumber[0] || inputnumber[0] > 100) ||
           (1 > inputnumber[1] || inputnumber[1] > 100) ||
           (inputnumber[0] > inputnumber[1]) )
            Console.WriteLine("Oh God something Wrong");
        else
            //Use Enumerable ranage to generate number then use agreate to do a recursive task.
            Console.WriteLine(Enumerable.Range(inputnumber[0], 1 + (inputnumber[1] - inputnumber[0])).Sum(x => x * x));

    }
  }
}
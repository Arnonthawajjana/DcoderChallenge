using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

//Compiler version 4.0, .NET Framework 4.5

namespace DcoderChallenge.Challenge.Easy
{
    //Challenge
    //https://code.dcoder.tech/challenges/57accf2a1e1ff69730eda7eb/learn-sum-of-numbers
  public class E01_Learn_Sum_Of_Number
  {
    public static void Main(string[] args)
    {
        int[] inputnumber = Array.ConvertAll(Console.ReadLine().Split(" ",StringSplitOptions.None), Convert.ToInt32);
        if(inputnumber.Any(x => (1 > x && x > 1000)) )
            Console.WriteLine("Oh God something Wrong");
        else
            Console.WriteLine(Convert.ToInt16(inputnumber[0] + inputnumber[1]));
    }
  }
}
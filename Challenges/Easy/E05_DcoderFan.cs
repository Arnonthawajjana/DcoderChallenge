using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

//Compiler version 4.0, .NET Framework 4.5

namespace DcoderChallenge.Challenge.Easy
{
    //Challenge
    //https://code.dcoder.tech/challenges/57a8f2601e1ff69730eda043/dcooooooooooder-fan
  public class E05_DcoderFan
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
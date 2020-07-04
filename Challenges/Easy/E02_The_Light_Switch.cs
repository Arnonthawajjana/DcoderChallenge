using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

//Compiler version 4.0, .NET Framework 4.5

namespace DcoderChallenge.Challenge.Easy
{
    //Challenge
    //https://code.dcoder.tech/challenges/57a8f5121e1ff69730eda045/the-light-switch
  public class E02_The_Light_Switch
  {
    public static void Main(string[] args)
    {
      short[] inputnumber = Array.ConvertAll(Console.ReadLine().Split(" ",StringSplitOptions.None), Convert.ToInt16);
      Console.WriteLine(Convert.ToInt16(inputnumber[0] ^ inputnumber[1]));
    }
  }
}
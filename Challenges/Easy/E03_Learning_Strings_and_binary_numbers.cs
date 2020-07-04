using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

//Compiler version 4.0, .NET Framework 4.5

namespace DcoderChallenge.Challenge.Easy
{
    //Challenge
    //https://code.dcoder.tech/challenges/57a650df1e1ff69730ed9aad/learning-strings-and-binary-numbers
  public class E03_Learning_Strings_and_binary_numbers
  {
    public static void Main(string[] args)
    {
      //Your code goes here
      String[] inputTyping = Console.ReadLine().Split(' ', StringSplitOptions.None);
      Console.WriteLine(Convert.ToInt32(inputTyping[0].Contains(inputTyping[1])));
    }
  }
}
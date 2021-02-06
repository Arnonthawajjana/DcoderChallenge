using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//Compiler version 4.0, .NET Framework 4.5

namespace DcoderChallenge.Challenge.Medium
{
    //Challenge
    //https://code.dcoder.tech/challenges/579bcc9895dbaefb44297d63/learning-strings-with-pig-latin
  public class M02_Learning_Strings_With_Pig_Latin
  {
    public static string pig_latin(string input)
    {
        var validateValues = "aeiou";
        var isFirstLetterIsConsonant = validateValues.IndexOf(input[0], StringComparison.InvariantCultureIgnoreCase) == (-1) ;
        input = isFirstLetterIsConsonant
                ? String.Concat(input.Substring(1), input[0], "ay") // cut first letter concat with "ay" then Apeend at tail.
                : String.Concat(input, "way"); //just appen at tail.
        return input;
    }
    public static void Main(string[] args)
    {
        Console.WriteLine(pig_latin(Console.ReadLine()));
    }
  }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//Compiler version 4.0, .NET Framework 4.5

namespace DcoderChallenge.Challenge.Medium
{
    //Challenge
    //https://code.dcoder.tech/challenges/579b4d01bc006607246b41ae/learning-even-odds-with-strings-and-loops
  public class M01_Learning_Even_Odds_With_Strings_And_Loops
  {
    public static void Main(string[] args)
    {
        int numTestCase = Convert.ToInt32(Console.ReadLine());
        if(1 > numTestCase || numTestCase > 10) Console.WriteLine("What too less");
        else{
            var listText = new List<string>();
            for(int i = 0; i < numTestCase; i++)
            {
                listText.Add(Console.ReadLine().Trim());
            }
            foreach(string textIn in listText)
            {
                var first = new StringBuilder();
                var second = new StringBuilder();
                for(int i = 0; i < textIn.Length; i++)
                {
                    if((i & 1) != 1) first.Append(textIn[i]);
                    else second.Append(textIn[i]);
                }
                Console.WriteLine($"{first} {second}");
            }

        }
    }
  }
}
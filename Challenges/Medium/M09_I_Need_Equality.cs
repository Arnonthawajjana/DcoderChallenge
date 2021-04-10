using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//Compiler version 4.0, .NET Framework 4.5

namespace DcoderChallenge.Challenge.Medium
{
    //Challenge
    //https://code.dcoder.tech/challenges/57b6c93a1e1ff69730edb22e/i-need-equality
  public class M09_I_Need_Equality
  {
    public static void Main(string[] args)
    {
        bool result = false;
        string text1 = Console.ReadLine();
        string text2 = Console.ReadLine();

        if(text1.Length == text2.Length)
        {
            int text1value = 0;
            int text2value = 0;
            for(int i = 0; i < text1.Length; i++)
            {
                text1value += text1[i];
                text2value += text2[i];
            }

            result = text1value == text2value;
        }

        Console.WriteLine(result ? "Yes" : "No");
    }
  }
}
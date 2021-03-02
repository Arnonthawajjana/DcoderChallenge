using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//Compiler version 4.0, .NET Framework 4.5

namespace DcoderChallenge.Challenge.Medium
{
    //Challenge
    //https://code.dcoder.tech/challenges/57ac40301e1ff69730eda713/string---half-of-the-half
  public class M06_String_Half_Of_The_Half
  {
    public static void Main(string[] args)
    {
        int testcase = Convert.ToInt32(Console.ReadLine());
        if(1 > testcase || testcase > 100) Console.WriteLine("WHAT is OVER limit");
        else{
            var listText = new List<String>();
            for(int i = 0; i < testcase; i++)
            {
                listText.Add(Console.ReadLine());
            }
            foreach(String item in listText)
            {
                for(int j = 0; j < item.Length/2; j+=2)
                    Console.Write($"{item[j]}");
                Console.Write("\n");
            }
        }
    }
  }
}
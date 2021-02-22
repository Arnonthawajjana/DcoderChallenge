using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//Compiler version 4.0, .NET Framework 4.5

namespace DcoderChallenge.Challenge.Medium
{
    //Challenge
    //https://code.dcoder.tech/challenges/57a8e9581e1ff69730eda037/the-divisibility-test
  public class M05_The_Divisibility_Test
  {
    public static void Main(string[] args)
    {
        int roundTest = Convert.ToInt32(Console.ReadLine());
        if(1 > roundTest || roundTest > 100000)
            Console.WriteLine("WTF Game is not good");
        else{
                for(int i = 0 ; i < roundTest; i++)
                {
                    int[] setOfNumber = Array.ConvertAll(Console.ReadLine().Split(" ", StringSplitOptions.None), Convert.ToInt32);
                    int n = setOfNumber[0], x = setOfNumber[1], y = setOfNumber[2];
                    int result = 1;
                    var devisable = new List<int>();
                    for(int j = 1; result < n; j++)
                    {
                        result = j*x;
                        if(result % y != 0 && result < n) devisable.Add(result);
                    }
                    for(int z = 0 ; z < devisable.Count; z++)
                        Console.Write((z+1) == devisable.Count? $"{devisable[z]}\n"  : $"{devisable[z]} ");
                }
        }
    }
  }
}
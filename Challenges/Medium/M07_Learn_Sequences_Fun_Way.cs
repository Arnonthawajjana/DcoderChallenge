using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//Compiler version 4.0, .NET Framework 4.5

namespace DcoderChallenge.Challenge.Medium
{
    //Challenge ** Partial solve
    //https://code.dcoder.tech/challenges/57ac63001e1ff69730eda73e/learn-sequences-fun-way
  public class M07_Learn_Sequences_Fun_Way
  {
    public static void Main(string[] args)
    {
        int numberArray = Convert.ToInt32(Console.ReadLine());
        if(2 > numberArray || numberArray > 100) Console.WriteLine("OverLimit 2<=n<=100");
        else{
            int[] arrayValue = Array.ConvertAll(Console.ReadLine().Split(" ", StringSplitOptions.None), Convert.ToInt32);
            bool result = true;
            int j = numberArray-1;
            for(int i = 0; i < (numberArray/2)+1 && j > i; i++)
            {
                if (!result) break;
                result = Math.Abs(arrayValue[i]) == Math.Abs(arrayValue[j]);
                j--;
            }
            Console.WriteLine(result ? "Yes": "No" );
        }
    }
  }
}
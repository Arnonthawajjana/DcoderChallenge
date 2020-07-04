using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

//Compiler version 4.0, .NET Framework 4.5

namespace DcoderChallenge.Challenge.Easy
{
    //Challenge
    //https://code.dcoder.tech/challenges/57ae1fbd1e1ff69730eda9db/using-loops-to-draw-patternspyramid
  public class E07_Using_Loop_draw_Pyramid
  {
    public static void Main(string[] args)
    {
        //Your code goes here
        int i,j,n;
        int input = 5;//Convert.ToInt32(Console.ReadLine());
        n = input + 1;
        for(i=1;i<n;i++)
        {
            for(j=1;j<n-i;j++)
                Console.Write(" ");
            for(j=1;j<=2*i-1;j++)
                Console.Write("*");
            Console.Write("\n");

        }

    }
  }

}
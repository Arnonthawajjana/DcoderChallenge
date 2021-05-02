using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//Compiler version 4.0, .NET Framework 4.5

namespace DcoderChallenge.Challenge.Medium
{
    //Challenge
    //https://code.dcoder.tech/challenges/57b70aa31e1ff69730edb26a/the-game-of-power
  public class M10_The_Game_Of_Power
  {
    public static void Main(string[] args)
    {
        var numbers = new List<int>();
        int testNumber = Convert.ToInt32(Console.ReadLine());

        // insert Area
        for(int i = 0; i < testNumber; i++)
            numbers.Add(Convert.ToInt32(Console.ReadLine()));

        foreach(var num in numbers)
        {
            // Find Square root see the result if has decimal number then round it up
            // the pow that result then compare the number and rounded up result
            // if equal 0 that mean 'num' is power of 2
            // Easiest to make you understand this easier.
            /*
              double variable = Math.Sqrt(num);
              double roundedup = Math.Round(variable);
              double reuslt = Math.Abs(num - Math.Pow(roundedup,2));
            */

            Console.WriteLine(Math.Abs(num - Math.Pow(Math.Round(Math.Sqrt(num)),2 )));
        }
    }
  }
}
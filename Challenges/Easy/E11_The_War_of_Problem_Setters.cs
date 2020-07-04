using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using static System.Math;

//Compiler version 4.0, .NET Framework 4.5

namespace DcoderChallenge.Challenge.Easy
{
    //Challenge
    //https://code.dcoder.tech/challenges/57b3924c1e1ff69730edaf4d/the-war-of-problem-setters
  public class E11_The_War_of_Problem_Setters
  {
    public static void Main(string[] args)
    {
        int[] pointsGarry = Array.ConvertAll(Console.ReadLine().Split(" ",StringSplitOptions.None), Convert.ToInt32);
        int[] pointsSharry = Array.ConvertAll(Console.ReadLine().Split(" ",StringSplitOptions.None), Convert.ToInt32);

        if(ValidatePointOfArray(pointsGarry) || ValidatePointOfArray(pointsSharry))
            Console.WriteLine($"WTF are you input here!!! number error");

        else{
            int result = pointsGarry.Sum() - pointsSharry.Sum();
            switch(Math.Sign(result))
            {
                case 1 :
                    Console.Write("Garry ");
                    break;
                case 0 :
                    Console.Write("None ");
                    break;
                case -1 :
                    Console.Write("Sharry ");
                    break;
            }

            Console.Write($"{Math.Abs(result)}\n");

        }
    }
    public static bool ValidatePointOfArray(int[] points)
    {
        return (points.Length > 3 || points.Length <3 || Array.Exists(points, x => (x > 10 || 1 > x)) );
    }
  }
}
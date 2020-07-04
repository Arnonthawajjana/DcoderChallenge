using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

//Compiler version 4.0, .NET Framework 4.5

namespace DcoderChallenge.Challenge.Easy
{
    //Challenge
    //https://code.dcoder.tech/challenges/57b380501e1ff69730edaf42/the-sum-of-array
  public class E10_The_Sum_of_Array
  {
    public static void Main(string[] args)
    {
        // input number of array
        int numberElement = Convert.ToInt32(Console.ReadLine());
        if(1 > numberElement || numberElement > 100)
            Console.WriteLine("Number Under or Over limit 1<=N<=100");

        // input number for sum process ....
        else{
            var validateValues = new char[] { '-', '.'};
            string[] valueArray = Console.ReadLine().Split(" ",StringSplitOptions.None);

            if(valueArray.Length != numberElement)
                Console.WriteLine("You put number too much or less than you told me");

        // Concept looping with validate avoid too much loop that could make process more slower.
            else{
                int result = 0;
                for(int i = 0; i < numberElement; i++)
                {
                    if((valueArray[i].Length > 2 && valueArray[i] != "100") || valueArray[i].IndexOfAny(validateValues) > -1)
                    {
                        Console.WriteLine($"WTF are you input here!!! number error at {valueArray[i]}");
                        break;
                    }
                    result += Convert.ToInt32(valueArray[i]);
                }
                Console.WriteLine(result);
                }
            }
        }
    }
}
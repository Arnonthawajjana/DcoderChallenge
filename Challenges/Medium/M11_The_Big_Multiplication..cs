using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//Compiler version 4.0, .NET Framework 4.5

namespace DcoderChallenge.Challenge.Medium
{
    //Challenge
    //https://code.dcoder.tech/challenges/57bce2e97b6a33c622e8dbea/the-big-multiplication
  public class M11_The_Big_Multiplication
  {
    public static void Main(string[] args)
    {
        //https://www.geeksforgeeks.org/modulo-1097-1000000007/

        int sizeOfArray = Convert.ToInt32(Console.ReadLine());
        var items = Array.ConvertAll(Console.ReadLine().Split(" ", StringSplitOptions.None), Convert.ToInt32);
        if(items.Length != sizeOfArray)
            Console.WriteLine("Over limit size array");

        else{
            long result = 1;
            foreach(int item in items)
                result = (result*item) % (1000000007);

            Console.WriteLine(result);
        }
    }
  }
}
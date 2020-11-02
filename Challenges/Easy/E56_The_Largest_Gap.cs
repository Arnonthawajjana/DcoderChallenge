using System;
using System.Globalization;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

//Compiler version 4.0, .NET Framework 4.5

namespace DcoderChallenge.Challenge.Easy
{
    //Challenge
    //https://code.dcoder.tech/challenges/5b2ec2b9a5c3787cda197fbf/the-largest-gap
    public class E56_The_Largest_Gap
    {
        public static void Main(string[] args)
        {
            int arraySize = Convert.ToInt32(Console.ReadLine());
            if(1 > arraySize || (long)arraySize > (long)Math.Pow(10, 3))
                Console.WriteLine("Too Large for Array");
            else{
                int[] elements = Array.ConvertAll(Console.ReadLine().Split(' ',StringSplitOptions.None), Convert.ToInt32);
                if(elements.Length != arraySize)
                    Console.WriteLine("Input Elements mismatched");
                else{
                    int min = elements[0];
                    int max = elements[0];
                    foreach(int item in elements)
                    {
                        if(item > max) max = item;
                        if(item < min) min = item;
                    }
                    Console.WriteLine(max != -1 && min != -1 ? Convert.ToString(Math.Abs(min - max)) : "ERROR Some elements breach the limit");
                }
            }
        }
    }
}
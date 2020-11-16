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
    //https://code.dcoder.tech/challenges/5b2ed2e3a5c3787cda197fe9/special-array
    public class E61_Special_Array
    {
        public static void Main(string[] args)
        {
            int arraySize = Convert.ToInt32(Console.ReadLine());
            if(1 > arraySize || arraySize > 100)
                Console.WriteLine("Array size reached limit");
            else{
                int[] elements = Array.ConvertAll(Console.ReadLine().Split(' ', StringSplitOptions.None), Convert.ToInt32);
                if(elements.Length != arraySize)
                    Console.WriteLine("array not match with input");
                else{
                    bool result = true;
                    foreach(int item in elements)
                    {
                        if(item < 1)
                        {
                            result = false;
                            break;
                        }
                    }
                    Console.WriteLine(result? "Yes": "No" );
                }
            }

        }
    }
}
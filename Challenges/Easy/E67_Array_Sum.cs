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
    //https://code.dcoder.tech/challenges/5b61e933527d3b5ac5cecda3/array-sum
    public class E67_Array_Sum
    {
        public static void Main(string[] args)
        {
            int sizeOfArray = Convert.ToInt32(Console.ReadLine());
            if(1 > sizeOfArray || sizeOfArray > 100)
                Console.WriteLine("Fuck Sake is Over Limit");
            else{
                int[] arrayOfnumbers = Array.ConvertAll(Console.ReadLine().Split(" ", StringSplitOptions.None), Convert.ToInt32);
                if(arrayOfnumbers.Length != sizeOfArray)
                    Console.WriteLine("Size mismatched");
                else{
                    int allsum = 0;
                    int highest = 0;
                    int i = 0;
                    for(; i < arrayOfnumbers.Length; i++)
                    {
                        if(0 > arrayOfnumbers[i] || arrayOfnumbers[i] > 1000)
                        {
                            Console.WriteLine("Size of number in array is over limit");
                            break;
                        }
                        else
                        {
                            if(arrayOfnumbers[i] > highest) highest = arrayOfnumbers[i];
                            allsum += arrayOfnumbers[i];
                        }
                    }
                    if(i == sizeOfArray)
                    {
                        Console.WriteLine(allsum % highest);
                    }

                }
            }
        }
    }
}
using System;
using System.Globalization;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

//Compiler version 4.0, .NET Framework 4.5

namespace DcoderChallenge.Challenge.Easy
{
    //Challenge
    //https://code.dcoder.tech/challenges/5b757d9d791e284892a42b4a/swapmaster-solves-symmetric-swap
    public class E75_Swapmaster_Solves_Symmetric_Swap
    {
        public static void Main(string[] args)
        {
            int number = Convert.ToInt32(Console.ReadLine());
            if(2 > number || number > 100) Console.WriteLine("What is happen is over limit");
            else{
                int[] dataArray = Array.ConvertAll(Console.ReadLine().Split(" ", StringSplitOptions.None), Convert.ToInt32);
                if(dataArray.Length != number)  Console.WriteLine("Size is mismatch");
                else{
                    int i = 0;
                    int j = number-1;
                    for(; i < number/2 ; i++)
                    {
                        if(1 > dataArray[i] || dataArray[i] > 1000) {Console.WriteLine("Number is over limit"); break;}
                        else{
                            int temp = dataArray[i];
                            dataArray[i] = dataArray[j];
                            dataArray[j] = temp;

                            j--;
                        }
                    }
                    i = 0;
                    for(; i < number; i++)
                        Console.Write(i < number-1 ? $"{dataArray[i]} " : $"{dataArray[i]}");
                }
            }
        }
    }
}
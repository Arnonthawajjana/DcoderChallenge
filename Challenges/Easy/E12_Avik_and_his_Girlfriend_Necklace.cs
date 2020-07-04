using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using static System.Math;

//Compiler version 4.0, .NET Framework 4.5

namespace DcoderChallenge.Challenge.Easy
{
    //Challenge
    //https://code.dcoder.tech/challenges/57b711861e1ff69730edb27b/avik-and-his-girlfriends-necklace
    public class E12_Avik_and_his_Girlfriend_Necklace
    {
        public static void bubbleSort(int[] arr)
        {
            int i, j, temp, n = arr.Length;
            bool swapped;
            for (i = 0; i < n - 1; i++)
            {
                if(1 > arr[i] || arr[i] > 100)
                {
                  Console.WriteLine("Oh God something Wrong");
                  break;
                }

                swapped = false;
                for (j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                        swapped = true;
                    }
                }

                if (swapped == false)
                        break;
            }
        }
        public static void Main(string[] args)
        {
          int numberElement = Convert.ToInt32(Console.ReadLine());
          if(1 > numberElement || numberElement > 100)
            Console.WriteLine("Number Under or Over limit 1<=N<=100");

          else{
            int[] inputNumbers = Array.ConvertAll(Console.ReadLine().Split(" ",StringSplitOptions.None), Convert.ToInt32);
            bubbleSort(inputNumbers);
            Array.ForEach(inputNumbers, x => { Console.Write($"{x} "); });
          }
        }
    }
}
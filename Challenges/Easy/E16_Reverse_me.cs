using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Math;

//Compiler version 4.0, .NET Framework 4.5

namespace DcoderChallenge.Challenge.Easy
{
    //Challenge
    //https://code.dcoder.tech/challenges/57c714ce7b6a33c622e8e594/reverse-me
    public class E16_Reverse_me
    {
        public static void Main(string[] args)
        {
            // Failed one test case
            // suspect last test cse should be 10000 after reverse end up "00001" not "1" reverse integer not string.
            // string inputNumberText = Console.ReadLine();
            // int inputNumber = Convert.ToInt32(inputNumberText);
            // if (1 > inputNumber || inputNumber > 10000)
            //     Console.WriteLine("Number Under or Over limit 1<=N<=10000");
            // else
            // {
            //     char[] array = inputNumberText.ToCharArray();
            //     Array.Reverse(array);
            //     Console.WriteLine(new String(array));
            // }

            //Remodel from https://www.javatpoint.com/csharp-program-to-reverse-number
            // Pass all test case
            int inputNumber, reverse = 0, remainder;
            inputNumber = Convert.ToInt32(Console.ReadLine());
            if (1 > inputNumber || inputNumber > 10000)
                Console.WriteLine("Number Under or Over limit 1<=N<=10000");
            else
            {
                while (inputNumber != 0)
                {
                    inputNumber = DivRem( inputNumber, 10, out remainder);
                    reverse = reverse * 10 + remainder;
                }
                Console.Write(reverse);
            }
        }
    }
}
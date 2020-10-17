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
    //https://code.dcoder.tech/challenges/5b28efc162db8b46ab2ac725/divide-the-array
    public class E54_Divide_The_Array
    {
        public static bool validateNumberRange(int number) => 1 >number || (long)number > (long)Math.Pow(10,5);
        public static bool validateNumberEven(long number) => ((number & 1) != 1);
        public static void Main(string[] args)
        {
            int numberOfArray = Convert.ToInt32(Console.ReadLine());
            if(1 > numberOfArray || (long)numberOfArray > (long)Math.Pow(10,3))
                Console.WriteLine("Number is Overlimit");
            else{
                long[] elementNumbers = Array.ConvertAll(Console.ReadLine().Split(' ', StringSplitOptions.None), Convert.ToInt64);
                int index = 0;
                do{
                    if(validateNumberEven(index+1) && validateNumberEven(elementNumbers[index]))
                        Console.Write("{0} ",elementNumbers[index]);
                    index++;
                }
                while(index < elementNumbers.Length);

            }
        }
    }
}
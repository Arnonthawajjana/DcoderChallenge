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
    //https://code.dcoder.tech/challenges/5b28ea8562db8b46ab2ac711/leap-year
    public class E73_Leap_Year
    {
        public static void Main(string[] args)
        {
            int arraySize = Convert.ToInt32(Console.ReadLine());
            if(1 > arraySize || arraySize > 100) Console.WriteLine("WTF!!!!");
            else{
                var listInt = new List<int>();
                for(int i = 0; i < arraySize; i++)
                {
                    int tempCheckValue = Convert.ToInt32(Console.ReadLine());
                    if(Math.Pow(10,3) > tempCheckValue || tempCheckValue > Math.Pow(10,5))
                    {
                        Console.WriteLine("WTF over limit");
                        break;
                    }
                    else
                        listInt.Add(tempCheckValue);

                }
                foreach(int temp in listInt)
                    Console.WriteLine(DateTime.IsLeapYear(temp)? "Yes" : "No");
            }
        }
    }
}
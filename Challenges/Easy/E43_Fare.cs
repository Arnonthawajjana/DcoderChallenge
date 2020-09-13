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
    //https://code.dcoder.tech/challenges/5b1be280d9432b981bd82727/fare

    public class E43_Fare
    {
        public static bool ValidateValue(int[] values)
        {
            return (1 > values[0] || 1 > values[1] || 1 > values[2] || 1 > values[3]) ||
                (values[0] > 1000 || values[1] > 1000 || values[2] > 1000 || values[3] > 1000);
        }
        public static void Main(string[] args)
        {
            //A = 0, M = 1, N = 2, D = 3
            int[] pricesanddistances = Array.ConvertAll(Console.ReadLine().Split(" ", StringSplitOptions.None),Convert.ToInt32);
            if(pricesanddistances.Length != 4)
                Console.WriteLine("Fail Insert");
            else{
                if(ValidateValue(pricesanddistances)) Console.WriteLine("Good Bye Some Value FAIL");
                else{
                    //Formula Case travel under first distance fare' = (D*M) = Fare;
                    if(pricesanddistances[3] <= pricesanddistances[0])Console.WriteLine(pricesanddistances[3]*pricesanddistances[1]);
                    //Formula Case travel over first distance fare' = ((D-A)*N)+(A*M) = Fare;
                    else Console.WriteLine(((pricesanddistances[3] - pricesanddistances[0])* pricesanddistances[2])+ (pricesanddistances[0]*pricesanddistances[1]));
                }
            }
        }
    }
}
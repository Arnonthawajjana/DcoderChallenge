using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

//Compiler version 4.0, .NET Framework 4.5

namespace DcoderChallenge.Challenge.Easy
{
    //Challenge
    //https://code.dcoder.tech/challenges/57cb3b8c7b6a33c622e8eaee/lets-get-gcd
    public class E18_lets_get_gcd
    {
        public static bool validateMinMaxNumber(int input)
        {
            return (1 > input || input > 1000);
        }
        public static void Main(string[] args)
        {
            //Euclidean algorithm
            //https://stackoverflow.com/questions/18541832/c-sharp-find-the-greatest-common-divisor
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            if (validateMinMaxNumber(a) || validateMinMaxNumber(b))
                Console.WriteLine("Some number is EXCEED limit 1<=N>=1000");
            else
            {
                while (a != 0 && b != 0)
                {
                    if (a > b)
                        a %= b;
                    else
                        b %= a;
                }
                Console.WriteLine(a == 0 ? b : a);
            }
        }
    }
}
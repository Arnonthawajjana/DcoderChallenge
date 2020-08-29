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
    //https://code.dcoder.tech/challenges/58ce59c932fd853c56db017d/equable-triangles

    public class E37_Equable_Triangles
    {
        public static bool ValidateTriangleSide(int side)
        {
            return 0 > side || side > 10000;
        }

        //Formulas and source
        //https://lostmathlessons.blogspot.com/2017/09/equable-shapes-with-integer-dimensions.html
        public static bool EqualbleTrianglesCheck(int[] sides)
        {
            bool result = false;
            int s4 =  sides.Sum()/2; // S4 = (S1 + S2 +S3)/2
            if(s4>sides[0] && s4>sides[1] && s4>sides[2])
                result = true;

            return result;
        }

        public static void Main(string[] args)
        {
            int testCaseNumber = Convert.ToInt32(Console.ReadLine());
            if(0 > testCaseNumber || testCaseNumber > 100) Console.WriteLine("FAIL CASE");
            else{
                for(int i = 0; i < testCaseNumber; i++)
                {
                    int[] sides = Array.ConvertAll(Console.ReadLine().Split(" ", StringSplitOptions.None), Convert.ToInt32);
                    if(ValidateTriangleSide(sides[0])||ValidateTriangleSide(sides[1])||ValidateTriangleSide(sides[2]))
                    {
                        Console.WriteLine("Over size");
                        break;
                    }
                    Array.Sort(sides);
                    Console.WriteLine(EqualbleTrianglesCheck(sides)? "True" : "False");
                }
            }
        }

    }
}
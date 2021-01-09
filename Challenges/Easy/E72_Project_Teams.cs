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
    //https://code.dcoder.tech/challenges/5cf3f4881681076686eade89/project-teams
    public class E72_Project_Teams
    {
        public static void Main(string[] args)
        {
            int studentCount = Convert.ToInt32(Console.ReadLine());
            if(3 > studentCount) Console.WriteLine("Teacher not happy with it bro");
            else{
                Console.WriteLine(studentCount/3);
            }
        }
    }
}
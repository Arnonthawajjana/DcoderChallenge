using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

//Compiler version 4.0, .NET Framework 4.5

namespace DcoderChallenge.Challenge.Easy
{
    //Challenge
    //https://code.dcoder.tech/challenges/57e592558c458b822a03a439/ill-be-the-next
    public class E24_Ill_Be_The_Next
    {
        public static void Main(string[] args)
        {
            string inputText = Console.ReadLine();
            byte[] bytes = Encoding.ASCII.GetBytes(inputText);
            for(int i = 0; i < bytes.Length; i++)
            {
                //should check ASCII table if you don't know what is this.
                if(bytes[i] >= (byte)65 && bytes[i] < (byte)90 || bytes[i] >=(byte)97 && bytes[i] < (byte)122)
                    bytes[i] += (byte)1;
                else if(bytes[i] == (byte)90 || bytes[i] == (byte)122)
                    bytes[i] = bytes[i] == 0x90 ? (byte)0x65 : (byte)0x97;

                Console.Write(Convert.ToChar(bytes[i]));
            }
        }
    }
}
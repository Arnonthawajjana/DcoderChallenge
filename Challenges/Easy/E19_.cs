using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

//Compiler version 4.0, .NET Framework 4.5

namespace DcoderChallenge.Challenge.Easy
{
    //Challenge
    //https://code.dcoder.tech/challenges/57c8a4577b6a33c622e8e744/the-predictor
    public class E19_The_Predictor
    {
        public static void Main(string[] args)
        {
            int size = 0;
            bool resultParse = Int32.TryParse(Console.ReadLine(), out size);
            if (!resultParse || 1 > size || size > 100)
                Console.WriteLine("Exceed or Under limit");
            else
            {
                int index = 0;
                double result = 0;
                //int result = 0;
                int[] elements = Array.ConvertAll(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries), Convert.ToInt32);
                if (size != elements.Length)
                    Console.WriteLine("Size missmatch");
                else
                {
                    for (; index < size; index++)
                    {
                        if (1 > elements[index] || elements[index] > 1000)
                            break;
                        result += elements[index];
                    }
                    if (index != elements.Length)
                        Console.WriteLine("Some Number is Exceed 1<= n <=1000");
                    else
                    {
                        //WHAT???
                        double realresult = result / index;
                        Console.WriteLine(Math.Round(realresult, 0, MidpointRounding.ToEven)); //Fail Case 3
                        //Console.WriteLine(Math.Truncate(elements.Average())); // Fail Case 4
                    }
                }
            }
        }
    }
}
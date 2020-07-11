using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Math;

//Compiler version 4.0, .NET Framework 4.5

namespace DcoderChallenge.Challenge.Easy
{
    //Challenge
    //https://code.dcoder.tech/challenges/57c414c17b6a33c622e8e28d/the-irritating-students
    public class E15_Problem_Statement
    {
        public static List<int> InputNumber()
        {
            var inputNumber = 0;
            var numbers = new List<int>();
            int numberTestCases = Convert.ToInt32(Console.ReadLine());
            if (1 > numberTestCases || numberTestCases > 100)
                Console.WriteLine("TestCaseNumber Under or Over limit 1<=N<=100");
            else
            {
                for (int i = 0; i < numberTestCases;)
                {
                    inputNumber = Convert.ToInt32(Console.ReadLine());
                    if (1 > inputNumber || inputNumber > 10000)
                        Console.WriteLine("Number Under or Over limit 1<=N<=10000, Reinsert");
                    else
                    {
                        numbers.Add(inputNumber);
                        i++;
                    }
                }
            }
            return numbers;
        }

        public static void Main(string[] args)
        {
            var numbers = InputNumber();
            if (numbers == null || numbers.Count == 0)
                Console.WriteLine("Fail Input");
            else
            {
                // After input the calculate should be here
                var remain = 0;
                var result = 0;
                foreach (int number in numbers)
                {
                    result = DivRem(number, 2, out remain);
                    Console.WriteLine($"{result} {result + remain}");
                    remain = 0;
                }

            }
        }
    }
}
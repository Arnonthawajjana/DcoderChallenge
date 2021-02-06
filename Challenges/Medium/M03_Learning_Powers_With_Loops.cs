using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//Compiler version 4.0, .NET Framework 4.5

namespace DcoderChallenge.Challenge.Medium
{
    //Challenge
    //https://code.dcoder.tech/challenges/579e4fed6d9e33cb530bc83a/learning-powers-with-loops
  public class M03_Learning_Powers_With_Loops
  {
    public static void Main(string[] args)
    {
        int[] inputNumber = Array.ConvertAll(Console.ReadLine().Split(" ", StringSplitOptions.None), Convert.ToInt32);
        double result = 1;
        if( (0 > inputNumber[0] || inputNumber[0] > 50) || (0 > inputNumber[1] || inputNumber[1] > 10))
            Console.WriteLine("Over limit not sure M or N");
        else{
            //Easier but this topic said you sould use Loops
            //Console.WriteLine(Math.Pow(inputNumber[0], inputNumber[1]));

            //Solution:
            //https://www.csharp-console-examples.com/loop/c-program-to-calculate-the-power-of-a-number-without-using-math-pow/
            bool sing = false;
            if (inputNumber[1] > 0) sing = true;
            inputNumber[1] = Math.Abs(inputNumber[1]);

            for(int i = 1; i <= inputNumber[1] ; i++)
            {
                if(sing)
                  result = result * inputNumber[0];
                else
                  result /= inputNumber[0];
            }

            Console.WriteLine(result);
        }
    }
  }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LettersInNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Started- Calculating 1 to 9");
            //ProcessOneToNine process = new ProcessOneToNine();
            //int output = process.ProcessAll(9);
            //Console.WriteLine(output);
            Console.WriteLine("Started- Calculating upto 99");
            ProcessTwentyToNintynine LetterCalculatorUpToNintyNine = new ProcessTwentyToNintynine();
            int output = LetterCalculatorUpToNintyNine.CalculateLetters(99);
            Console.WriteLine(output);
            Console.WriteLine("Started- Calculating Greater Than  100 But Less than 1000");
            ProcessHundredToLessThanThousand LetterCalculatorUpToNineNintyNine = new ProcessHundredToLessThanThousand();
            output = LetterCalculatorUpToNineNintyNine.CalculateLetters(199);
            Console.WriteLine("For 199 :" + output.ToString());
            output = LetterCalculatorUpToNineNintyNine.CalculateLetters(299);
            Console.WriteLine("For 299 :" + output.ToString());
            output = LetterCalculatorUpToNineNintyNine.CalculateLetters(399);
            Console.WriteLine("For 399 :" + output.ToString());
            output = LetterCalculatorUpToNineNintyNine.CalculateLetters(499);
            Console.WriteLine("For 499 :" + output.ToString());
            output = LetterCalculatorUpToNineNintyNine.CalculateLetters(599);
            Console.WriteLine("For 599 :" + output.ToString());
            output = LetterCalculatorUpToNineNintyNine.CalculateLetters(699);
            Console.WriteLine("For 699 :" + output.ToString());
            output = LetterCalculatorUpToNineNintyNine.CalculateLetters(799);
            Console.WriteLine("For 799 :" + output.ToString());
            output = LetterCalculatorUpToNineNintyNine.CalculateLetters(899);
            Console.WriteLine("For 899 :" + output.ToString());
            output = LetterCalculatorUpToNineNintyNine.CalculateLetters(999);
            Console.WriteLine("For 999 :" + output.ToString());
            Console.WriteLine("Started- Calculating Upto 1000");
            ProcessThousand LetterCalculatorUpToThousand = new ProcessThousand();
            output = LetterCalculatorUpToThousand.CalculateLetters(1000);
            Console.WriteLine("For 1000 :" + output.ToString());

            Console.ReadKey();
        }
    }
}

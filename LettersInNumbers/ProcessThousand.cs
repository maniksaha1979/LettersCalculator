using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LettersInNumbers
{
    public class ProcessThousand
    {
        private const string ONETHOUSAND = "OneThousand";

        private ProcessHundredToLessThanThousand CalculatorLessThanThousand;

        public ProcessThousand()
        {
           CalculatorLessThanThousand = new ProcessHundredToLessThanThousand();
        }

        public int CalculateLetters(int endrange)
        {
            int CountLetters = 0;
            if (endrange == 1000)
            {
                CountLetters = CountLetters + CalculatorLessThanThousand.CalculateLetters(999) + ONETHOUSAND.Length;
            }
            else
            {
                throw new OverflowException("Input out of range");
            }
            return CountLetters;
        }
    }
}

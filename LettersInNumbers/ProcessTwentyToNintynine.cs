using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LettersInNumbers
{
    public class ProcessTwentyToNintynine
    {

        private ProcessOneToNineteen OneToNineteenCalculator;
        public ProcessTwentyToNintynine()
        {
            OneToNineteenCalculator = new ProcessOneToNineteen();
        }
        public int CalculateLetters(int endrange)
        {
            int CountLetters = 0;
            int Remainder = 0;
            int DivisionResult = 0;
            Remainder = endrange % 10;
            DivisionResult = endrange / 10;
            if (DivisionResult <= 1 )
            {
                CountLetters = OneToNineteenCalculator.CalculateLetters(endrange);
            }
            else
            {
                CountLetters = OneToNineteenCalculator.CalculateLettersAllInRange();
                var LetterList = SetupHelper.CreateWordDictionaryForTens();
                var highestIndexInList = DivisionResult - 2;
                if (highestIndexInList > 0)
                {
                    for (int counter = 0; counter < highestIndexInList; counter++)
                    {
                        CountLetters = CountLetters + (10 * LetterList.ElementAt(counter).Value.Length);
                        CountLetters = CountLetters + OneToNineteenCalculator.CalculateLetters(9);
                    }

                    CountLetters = CountLetters + OneToNineteenCalculator.CalculateLetters(Remainder);
                    CountLetters = CountLetters + ((Remainder + 1) * LetterList.ElementAt(highestIndexInList).Value.Length);
                }
                else
                {
                    CountLetters = CountLetters + OneToNineteenCalculator.CalculateLetters(Remainder);
                    CountLetters = CountLetters + ((Remainder + 1) * LetterList.ElementAt(highestIndexInList).Value.Length);
                }

            }
            
            return CountLetters;
        }
    }
}

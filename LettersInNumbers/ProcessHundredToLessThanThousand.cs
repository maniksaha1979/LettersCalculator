using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LettersInNumbers
{
    public class ProcessHundredToLessThanThousand
    {
        private const string HUNDREDAND = "and";
        private const string HUNDRED = "hundred";

        private ProcessTwentyToNintynine TwentyToNintynineCalCulator;
        public ProcessHundredToLessThanThousand()
        {
            TwentyToNintynineCalCulator = new ProcessTwentyToNintynine();
        }

        public int CalculateLetters(int endrange)
        {
            int CountLetters = 0;
            int Remainder = 0;
            int DivisionResult = 0;
            if (endrange < 100)
            {
                CountLetters = TwentyToNintynineCalCulator.CalculateLetters(endrange);
            }
            else
            {
                Remainder = endrange % 100;
                DivisionResult = endrange / 100;
                var LetterList = SetupHelper.CreateWordDictionaryForOneToNineteen();
                var highestIndexInList = DivisionResult - 1;
                if (highestIndexInList > 0)
                {
                    for (int counter = 0; counter <= highestIndexInList; counter++)
                    {
                        CountLetters = CountLetters + TwentyToNintynineCalCulator.CalculateLetters(99);
                        if  (counter < highestIndexInList)
                        {
                            CountLetters = CountLetters + (100 * (LetterList.ElementAt(counter).Value.Length));
                            CountLetters = CountLetters +(100 * HUNDRED.Length);
                            CountLetters = CountLetters + (99 * HUNDREDAND.Length);
                        }
                        else
                        {
                            CountLetters = CountLetters + ((Remainder + 1) * (LetterList.ElementAt(highestIndexInList).Value.Length));
                            CountLetters = CountLetters + ((Remainder + 1) * HUNDRED.Length);
                            CountLetters = CountLetters + (Remainder * HUNDREDAND.Length);
                            CountLetters = CountLetters + TwentyToNintynineCalCulator.CalculateLetters(Remainder);

                        }
                    }
                    
                }
                else
                {
                    CountLetters = CountLetters + TwentyToNintynineCalCulator.CalculateLetters(99);
                    CountLetters = CountLetters + ((Remainder + 1) * (LetterList.ElementAt(highestIndexInList).Value.Length));
                    CountLetters = CountLetters + ((Remainder + 1) * HUNDRED.Length);
                    CountLetters = CountLetters + (Remainder * HUNDREDAND.Length);
                    CountLetters = CountLetters + TwentyToNintynineCalCulator.CalculateLetters(Remainder);
                }

            }

            return CountLetters;
        }
    }
}

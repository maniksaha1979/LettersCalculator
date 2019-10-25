using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LettersInNumbers
{
    public class ProcessOneToNineteen
    {
        public int ProcessAll()
        {
            int CountLetters = 0;
            foreach( var item in SetupHelper.CreateWordDictionaryForOneToNineteen())
            {
                CountLetters = CountLetters + item.Value.Length;
            }
            return CountLetters;
        }

        public int CalculateLettersAllInRange( int endrange)
        {
            int CountLetters = 0;
            foreach (var item in SetupHelper.CreateWordDictionaryForOneToNineteen())
            {
                if (endrange >= item.Key)
                CountLetters = CountLetters + item.Value.Length;
            }
            return CountLetters;
        }

        public int CalculateLettersAllInRange()
        {
            int CountLetters = 0;
            foreach (var item in SetupHelper.CreateWordDictionaryForOneToNineteen())
            {
                CountLetters = CountLetters + item.Value.Length;
            }
            return CountLetters;
        }

        public int CalculateLetters(int endrange)
        {
            int CountLetters = 0;
            if (endrange > 0)
            {
                foreach (var item in SetupHelper.CreateWordDictionaryForOneToNineteen())
                {
                    if (endrange >= item.Key)
                        CountLetters = CountLetters + item.Value.Length;
                }
            }
            return CountLetters;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LettersInNumbers
{
    public class SetupHelper
    {
        public static Dictionary<Int32, string> CreateWordDictionaryForOneToNineteen()
        {
            return new Dictionary<Int32, string>
                {
                    {1, "one"},
                    {2, "two"},
                    {3, "three"},
                    {4, "four"},
                    {5, "five"},
                    {6, "six"},
                    {7, "seven"},
                    {8, "eight"},
                    {9, "nine"},
                    {10, "ten"},
                    {11, "eleven"},
                    {12, "twelve"},
                    {13, "thirteen"},
                    {14, "fourteen"},
                    {15, "fifteen"},
                    {16, "sixteen"},
                    {17, "seventeen"},
                    {18, "eighteen"},
                    {19, "nineteen"}

                };
        }

        
        public static Dictionary<Int32, string> CreateWordDictionaryForTens()
        {
            return new Dictionary<Int32, string>
                {
                    {20, "twenty"},
                    {30, "thirty"},
                    {40, "forty"},
                    {50, "fifty"},
                    {60, "sixty"},
                    {70, "seventy"},
                    {80, "eighty"},
                    {90, "ninety"}
                };
        }

    }
}

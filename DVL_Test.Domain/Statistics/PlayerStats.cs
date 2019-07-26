using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVL_Test.Domain.Statistics
{
    public class PlayerStats
    {
        public double RealWPM { get; set; }
        public double WPM { get; set; }
        public int TypedWords { get { return TypedCorrectWords + TypedIncorrectWords; } }
        public int TypedCorrectWords { get { return _TypedCorrectWords ?? 0; } set { _TypedCorrectWords = value; } }
        private int? _TypedCorrectWords { get; set; }
        public int TypedIncorrectWords { get {  return _TypedIncorrectWords ?? 0; } set { _TypedIncorrectWords = value; } }
        private int? _TypedIncorrectWords { get; set; }
        public int TypedSymbols { get { return TypedCorrectSymbols+TypedIncorrectSymbols; } }
        public int TypedCorrectSymbols { get; set; }
        private int? _TypedCorrectSymbols { get; set; }
        public int TypedIncorrectSymbols { get { return _TypedInCorrectSymbols ?? 0; } set { _TypedInCorrectSymbols = value; } }
        private int? _TypedInCorrectSymbols { get; set; }

        public double getWPM(Stopwatch timer)
        {
            int wordsCount=TypedSymbols%5;
            if(wordsCount>=3)
                wordsCount++;
            wordsCount+=TypedSymbols/5;
            return WPM = ((double)(60000 * wordsCount)) / (double)timer.ElapsedMilliseconds;
        }
        public double getRealWPM(Stopwatch timer)
        {
            int wordsCount = TypedCorrectSymbols % 5;
            if (wordsCount >= 3)
                wordsCount++;
            wordsCount += TypedCorrectSymbols / 5;
            return RealWPM = ((double)(60000 * wordsCount)) / (double)timer.ElapsedMilliseconds;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVL_Test.Domain.Abstract
{
    public interface IDVLTest
    {
        IEnumerable<Word> Words { get; }

        void addWord(Word w);
        void removeWord(Word w);
        Word getRandomWord(Random r);
    }
}

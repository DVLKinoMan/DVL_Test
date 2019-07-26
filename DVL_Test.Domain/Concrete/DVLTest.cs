using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DVL_Test.Domain.Abstract;

namespace DVL_Test.Domain.Concrete
{
    public class DVLTest:IDVLTest
    {
        DVL_TestModel DVL_Entitie = new DVL_TestModel();
        public IEnumerable<Word> Words { get { return DVL_Entitie.Words; } }

        private int wordCount = -1;
        private List<Word> DBWords;

        public DVLTest()
        {
            DBWords = DVL_Entitie.Words.ToList();
        }

        public Word getRandomWord(Random r)
        {
            if (DBWords.Count == 0)
            {
                addWord(new Word{ Text = "something"});
                DBWords = DVL_Entitie.Words.ToList();
            }

            int i = r.Next(getDBWordCount());
            return DBWords.ElementAt(i);
        }

        private int getDBWordCount()
        {
            if (this.wordCount < 0)
            {
                this.wordCount = DVL_Entitie.Words.Count();
            }
            return this.wordCount;
        }


        public void addWord(Word w)
        {
            DVL_Entitie.Words.Add(w);
            DVL_Entitie.SaveChanges();
        }

        public void removeWord(Word w)
        {
            DVL_Entitie.Words.RemoveRange(DVL_Entitie.Words.Where(word => word.Text == w.Text));
            DVL_Entitie.SaveChanges();
        }


    }
}

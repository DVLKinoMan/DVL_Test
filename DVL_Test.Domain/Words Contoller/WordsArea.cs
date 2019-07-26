﻿using DVL_Test.Domain.Abstract;
using DVL_Test.Domain.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVL_Test.Domain.Words_Contoller
{
    public class WordsArea
    {
        public List<WordView> Words = new List<WordView>();
        //new words generated by getLineOfText method
        public List<WordView> NewWords;

        public int SymbolsOnCurrentLine { get { return _SymbolsOnCurrentLine ?? 0; } set { _SymbolsOnCurrentLine = value; } }
        private int? _SymbolsOnCurrentLine { get; set; }
        public int MaxSymbolsOnPerLine { get { return _MaxSymbolsOnPerLine ?? 38; } set { _MaxSymbolsOnPerLine = value; } }
        private int? _MaxSymbolsOnPerLine { get; set; }
        public string getLineOfText(int line)
        {
            IDVLTest d3 = new DVLTest();
            NewWords = new List<WordView>();
            Random r = new Random();
            string Text="";
            while (line!=0)
            {
                string word = d3.getRandomWord(r).Text;
                if (SymbolsOnCurrentLine == 0)
                {
                    Text += word;

                    Words.Add(new WordView { Word = word, Status = WordStatus.Right });
                    NewWords.Add(new WordView { Word = word, Status = WordStatus.Right });

                    SymbolsOnCurrentLine += word.Count();
                    continue;
                }
                Text += " ";
                SymbolsOnCurrentLine++;
                if (SymbolsOnCurrentLine + word.Count() > MaxSymbolsOnPerLine)
                {
                    SymbolsOnCurrentLine = 0;
                    line--;
                }
                Text += word;

                Words.Add(new WordView { Word = word, Status = WordStatus.Right });
                NewWords.Add(new WordView { Word = word, Status = WordStatus.Right });

                SymbolsOnCurrentLine += word.Count();
            }
            return Text;
        }
        public List<string> getWords(int wrNum)
        {
            IDVLTest d3 = new DVLTest();
            Random r = new Random();
            for (int i = 0; i < wrNum;i++ )
            {
                string word = d3.getRandomWord(r).Text;

                Words.Add(new WordView { Word = word, Status = WordStatus.Right });
            }
            return Words.Select(w=>w.Word).ToList();
        }
    }
}

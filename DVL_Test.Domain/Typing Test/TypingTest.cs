using DVL_Test.Domain.Statistics;
using DVL_Test.Domain.Words_Contoller;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVL_Test.Domain.Typing_Test
{
    public class TypingTest
    {
        public List<WordView> Words = new List<WordView>();

        public PlayerStats PlayerStats = new PlayerStats();

        private System.Timers.Timer timer = new System.Timers.Timer();

        private Stopwatch watch = new Stopwatch();
        //test's time in seconds
        public int TimeForTest = 60;

        public bool isRunning = false;

        public TypingTest()
        {
            timer.Interval = 1000;
            timer.Elapsed += TimerWithIntervalOneSecond;
        }
        public void ResetTypingTest(){
            resetTimer();
            //not true
            //PlayerStats.RealWPM = 0;
            //PlayerStats.WPM = 0;
        }
        #region Timer Methods
        private void TimerWithIntervalOneSecond(Object source, System.Timers.ElapsedEventArgs e)
        {
            if (Time <= 0)
            {
                ResetTypingTest();
                return;
            }
            Time--;
        }
        public void startTimer()
        {
            timer.Start();
            watch.Start();
            isRunning = true;
        }
        public void stopTimer()
        {
            timer.Stop();
            watch.Stop();
            isRunning = false;
        }
        public void resetTimer()
        {
            stopTimer();
            watch.Reset();
            Time = TimeForTest;
        }
        public string TimeToString()
        {
            string str = "";
            if (Time / 60 != 0)
                str += Time / 60 + ":";
            else str += "0:";
            int seconds = Time % 60;
            if (seconds < 10)
                str += "0" + seconds;
            else str += seconds;
            return str;
        }
        #endregion

        //time in seconds
        public int Time { get { return _Time ?? TimeForTest; } set { _Time = value; } }
        private int? _Time { get; set; }
        public double CurrentWPM { get { return Math.Round(PlayerStats.getWPM(watch), 3); } }
        public double CurrentRealWPM { get { return Math.Round(PlayerStats.getRealWPM(watch), 3); } }
        public string CurrentWPMString { get { return CurrentWPM + " WPM"; } }
        public string CurrentRealWPMString { get { return CurrentRealWPM + " (Real WPM)"; } }
        public WordView CurrentWordView { get { return Words.ElementAt(PlayerStats.TypedWords); }  }

        public void AddWord(WordView w)
        {
            Words.Add(w);
        }

        public void AddWords(IEnumerable<WordView> ws)
        {
            Words.AddRange(ws);
        }

        public void SaveStats(string playerWord,bool isCorrectWord)
        {
            if (isCorrectWord)
            {
                PlayerStats.TypedCorrectWords++;
                PlayerStats.TypedCorrectSymbols += playerWord.Length;
            }
            else
            {
                PlayerStats.TypedIncorrectWords++;
                PlayerStats.TypedIncorrectSymbols += playerWord.Length;
            }
        }
        
        public bool CheckIfTypingWordIsCorrect(string w, bool isTyped)
        {
            if (isTyped)
            {
                if (CurrentWordView.Word == w)
                {
                    return true;
                }
                return false;
            }
            else
            {
                if (w != string.Empty)
                {
                    if (CurrentWordView.Word.IndexOf(w) == 0)
                        return true;
                    return false;
                }
                return true;
            }
        }

    }
}

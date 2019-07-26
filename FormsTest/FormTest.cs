using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using DVL_Test.Domain.Abstract;
using DVL_Test.Domain.Concrete;
using DVL_Test.Domain.Words_Contoller;
using DVL_Test.Domain.Typing_Test;
using System.Diagnostics;

namespace FormsTest
{
    public partial class FormTest : Form
    {
        WordsArea wordsArea = new WordsArea();
        TypingTest typingTest = new TypingTest();
        int IndexOfWord = 0;
        bool wordIsActive = true;

        public FormTest()
        {
            InitializeComponent();
            addWordsToRichTextBoxForWords(10);
            labelTime.Text = typingTest.TimeToString();
            toolTipForTyping.SetToolTip(this.pictureBoxRestartTest, "Restart Test");
        }

        private string GetWordByIndexFromRichtextBox(int index)
        {
            return richTextBoxForWords.Text.Substring(index, richTextBoxForWords.Text.IndexOf(" ", index) - index);
        }

        private void addWordsToRichTextBoxForWords(int line)
        {
            richTextBoxForWords.Text += wordsArea.getLineOfText(line);
            typingTest.AddWords(wordsArea.NewWords);
        }
        private void UpdateRichTextBoxWordsColor(WordStatus status)
        {
            if (status==WordStatus.Wrong)
            {
                typingTest.CurrentWordView.Status = WordStatus.Wrong;
                richTextBoxForWords.Select(IndexOfWord, typingTest.CurrentWordView.Word.Count());
                richTextBoxForWords.SelectionBackColor = Color.Red;
                
            }
            else
            {
                if (status == WordStatus.Active)
                {
                    typingTest.CurrentWordView.Status = WordStatus.Active;
                    richTextBoxForWords.Select(IndexOfWord, typingTest.CurrentWordView.Word.Count());
                    richTextBoxForWords.SelectionBackColor = Color.Green;
                }
                else
                {
                    typingTest.CurrentWordView.Status = WordStatus.Right;
                    richTextBoxForWords.Select(IndexOfWord, typingTest.CurrentWordView.Word.Count());
                    richTextBoxForWords.SelectionBackColor = Color.White;
                }
            }
            richTextBoxForWords.ScrollToCaret();
            richTextBoxForWords.DeselectAll();
        }

        private void RestartTest()
        {
            wordsArea = new WordsArea();
            typingTest = new TypingTest();
            IndexOfWord = 0;
            wordIsActive = true;

            ResetTestInDesign();
            addWordsToRichTextBoxForWords(10);
            labelTime.Text = typingTest.TimeToString();
        }
        private void ResetTestInDesign()
        {
            wordIsActive = false;
            richTextBoxForWords.Text = "";
            textBoxForTyping.Text = "";
            wordIsActive = true;
        }
        
        private void textBoxForTyping_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Space)
            {
                string w = textBoxForTyping.Text;
                wordIsActive = false;
                textBoxForTyping.Text = string.Empty;
                if (w != string.Empty)
                {
                    int wrlen = typingTest.CurrentWordView.Word.Length;
                    if (typingTest.CheckIfTypingWordIsCorrect(w, true))
                    {
                        UpdateRichTextBoxWordsColor(WordStatus.Right);
                        typingTest.SaveStats(w, true);
                    }
                    else
                    {
                        UpdateRichTextBoxWordsColor(WordStatus.Wrong);
                        typingTest.SaveStats(w, false);
                    }
                    if (typingTest.PlayerStats.TypedWords == typingTest.Words.Count() - 10)
                        addWordsToRichTextBoxForWords(4);
                    IndexOfWord += wrlen + 1;
                }
            }
        }

        private void textBoxForTyping_TextChanged(object sender, EventArgs e)
        {
            if (typingTest.isRunning == false && richTextBoxForWords.Text!=string.Empty)
            {
                typingTest.startTimer();
                timer1.Start();
            }
            //richTextBoxForWords.ScrollToCaret();//not satisfied
            if (wordIsActive)
            {
                if (!typingTest.CheckIfTypingWordIsCorrect(textBoxForTyping.Text.Trim(), false))
                    UpdateRichTextBoxWordsColor(WordStatus.Wrong);
                else UpdateRichTextBoxWordsColor(WordStatus.Active);
            }
        }

        private void textBoxForTyping_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Space)
            {
                wordIsActive = true;
                textBoxForTyping.Text = string.Empty;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelTime.Text = typingTest.TimeToString();
            labelForWPM.Text = typingTest.CurrentWPMString;
            labelForRealWPM.Text = typingTest.CurrentRealWPMString;
            if (typingTest.Time <= 0)
            {
                ResetTestInDesign();
                UpdateResultTapPages();
                timer1.Stop();
                return;
            }
        }

        private void UpdateResultTapPages()
        {
            this.Size = new Size(1065, 622);
            labelCorrectSymbols.Text = typingTest.PlayerStats.TypedCorrectSymbols.ToString();
            labelResultIncorrectSymbols.Text = typingTest.PlayerStats.TypedIncorrectSymbols.ToString();
            labelTypedSymbols.Text = typingTest.PlayerStats.TypedSymbols.ToString();
            labelResultTypedWords.Text = typingTest.PlayerStats.TypedWords.ToString();
            labelIncorrectWords.Text = typingTest.PlayerStats.TypedIncorrectWords.ToString();
            labelResultCorrectWords.Text = typingTest.PlayerStats.TypedCorrectWords.ToString();
            labelRealResultWPM.Text = Math.Round( typingTest.PlayerStats.RealWPM, 3).ToString();
        }

        private void pictureBoxRestartTest_Click(object sender, EventArgs e)
        {
            RestartTest();
        }

        private void pictureBoxRestartTest_MouseEnter(object sender, EventArgs e)
        {
            pictureBoxRestartTest.Size = new Size(pictureBoxRestartTest.Width + 3, pictureBoxRestartTest.Height + 3);
        }

        private void pictureBoxRestartTest_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxRestartTest.Size = new Size(pictureBoxRestartTest.Width - 3, pictureBoxRestartTest.Height - 3);
        }

        #region Not Used
        private void backgroundWorkerUpdatingRichTextBox_DoWork(object sender, DoWorkEventArgs e)
        {
            RestartTest();
        }

        private void backgroundWorkerUpdatingRichTextBox_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            richTextBoxForWords.Enabled = true;
        }
        #endregion
    }
}

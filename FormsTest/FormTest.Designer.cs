namespace FormsTest
{
    partial class FormTest
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.richTextBoxForWords = new System.Windows.Forms.RichTextBox();
            this.textBoxForTyping = new System.Windows.Forms.TextBox();
            this.labelMessage = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelTime = new System.Windows.Forms.Label();
            this.labelForWPM = new System.Windows.Forms.Label();
            this.labelCurrentSpeedMessage = new System.Windows.Forms.Label();
            this.labelForRealWPM = new System.Windows.Forms.Label();
            this.tabControlResult = new System.Windows.Forms.TabControl();
            this.tabResultPage1 = new System.Windows.Forms.TabPage();
            this.labelResultMessageIncorrectWords = new System.Windows.Forms.Label();
            this.labelIncorrectWords = new System.Windows.Forms.Label();
            this.labelResultTypedCorrectWords = new System.Windows.Forms.Label();
            this.labelResultCorrectWords = new System.Windows.Forms.Label();
            this.labelResultMessageTypedWords = new System.Windows.Forms.Label();
            this.labelResultTypedWords = new System.Windows.Forms.Label();
            this.labelResultMessageRealWPM = new System.Windows.Forms.Label();
            this.labelRealResultWPM = new System.Windows.Forms.Label();
            this.tabResultPage2 = new System.Windows.Forms.TabPage();
            this.labelResultMessageCorrectSymbols = new System.Windows.Forms.Label();
            this.labelCorrectSymbols = new System.Windows.Forms.Label();
            this.labelResultMessageIncorrectSymbols = new System.Windows.Forms.Label();
            this.labelResultIncorrectSymbols = new System.Windows.Forms.Label();
            this.labelResultMessageTypedSymbols = new System.Windows.Forms.Label();
            this.labelTypedSymbols = new System.Windows.Forms.Label();
            this.pictureBoxRestartTest = new System.Windows.Forms.PictureBox();
            this.toolTipForTyping = new System.Windows.Forms.ToolTip(this.components);
            this.backgroundWorkerUpdatingRichTextBox = new System.ComponentModel.BackgroundWorker();
            this.tabControlResult.SuspendLayout();
            this.tabResultPage1.SuspendLayout();
            this.tabResultPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRestartTest)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBoxForWords
            // 
            this.richTextBoxForWords.AutoWordSelection = true;
            this.richTextBoxForWords.BackColor = System.Drawing.Color.White;
            this.richTextBoxForWords.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.richTextBoxForWords.HideSelection = false;
            this.richTextBoxForWords.Location = new System.Drawing.Point(21, 93);
            this.richTextBoxForWords.Name = "richTextBoxForWords";
            this.richTextBoxForWords.ReadOnly = true;
            this.richTextBoxForWords.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBoxForWords.ShortcutsEnabled = false;
            this.richTextBoxForWords.Size = new System.Drawing.Size(881, 81);
            this.richTextBoxForWords.TabIndex = 1;
            this.richTextBoxForWords.TabStop = false;
            this.richTextBoxForWords.Text = "";
            // 
            // textBoxForTyping
            // 
            this.textBoxForTyping.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxForTyping.Location = new System.Drawing.Point(21, 260);
            this.textBoxForTyping.Multiline = true;
            this.textBoxForTyping.Name = "textBoxForTyping";
            this.textBoxForTyping.Size = new System.Drawing.Size(881, 42);
            this.textBoxForTyping.TabIndex = 2;
            this.textBoxForTyping.TextChanged += new System.EventHandler(this.textBoxForTyping_TextChanged);
            this.textBoxForTyping.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxForTyping_KeyDown);
            this.textBoxForTyping.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxForTyping_KeyUp);
            // 
            // labelMessage
            // 
            this.labelMessage.AutoSize = true;
            this.labelMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMessage.Location = new System.Drawing.Point(15, 25);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(328, 31);
            this.labelMessage.TabIndex = 3;
            this.labelMessage.Text = "Type as Fast as You Can:";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTime.Location = new System.Drawing.Point(909, 260);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(2, 39);
            this.labelTime.TabIndex = 4;
            // 
            // labelForWPM
            // 
            this.labelForWPM.AutoSize = true;
            this.labelForWPM.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelForWPM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelForWPM.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelForWPM.Location = new System.Drawing.Point(629, 217);
            this.labelForWPM.Name = "labelForWPM";
            this.labelForWPM.Size = new System.Drawing.Size(111, 35);
            this.labelForWPM.TabIndex = 5;
            this.labelForWPM.Text = "0 WPM";
            // 
            // labelCurrentSpeedMessage
            // 
            this.labelCurrentSpeedMessage.AutoSize = true;
            this.labelCurrentSpeedMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCurrentSpeedMessage.Location = new System.Drawing.Point(15, 218);
            this.labelCurrentSpeedMessage.Name = "labelCurrentSpeedMessage";
            this.labelCurrentSpeedMessage.Size = new System.Drawing.Size(262, 31);
            this.labelCurrentSpeedMessage.TabIndex = 6;
            this.labelCurrentSpeedMessage.Text = "Your Current Speed:";
            // 
            // labelForRealWPM
            // 
            this.labelForRealWPM.AutoSize = true;
            this.labelForRealWPM.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelForRealWPM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelForRealWPM.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelForRealWPM.Location = new System.Drawing.Point(303, 218);
            this.labelForRealWPM.Name = "labelForRealWPM";
            this.labelForRealWPM.Size = new System.Drawing.Size(199, 35);
            this.labelForRealWPM.TabIndex = 7;
            this.labelForRealWPM.Text = "0 (Real WPM)";
            // 
            // tabControlResult
            // 
            this.tabControlResult.Controls.Add(this.tabResultPage1);
            this.tabControlResult.Controls.Add(this.tabResultPage2);
            this.tabControlResult.Location = new System.Drawing.Point(21, 355);
            this.tabControlResult.Name = "tabControlResult";
            this.tabControlResult.SelectedIndex = 0;
            this.tabControlResult.Size = new System.Drawing.Size(407, 216);
            this.tabControlResult.TabIndex = 8;
            // 
            // tabResultPage1
            // 
            this.tabResultPage1.Controls.Add(this.labelResultMessageIncorrectWords);
            this.tabResultPage1.Controls.Add(this.labelIncorrectWords);
            this.tabResultPage1.Controls.Add(this.labelResultTypedCorrectWords);
            this.tabResultPage1.Controls.Add(this.labelResultCorrectWords);
            this.tabResultPage1.Controls.Add(this.labelResultMessageTypedWords);
            this.tabResultPage1.Controls.Add(this.labelResultTypedWords);
            this.tabResultPage1.Controls.Add(this.labelResultMessageRealWPM);
            this.tabResultPage1.Controls.Add(this.labelRealResultWPM);
            this.tabResultPage1.Location = new System.Drawing.Point(4, 22);
            this.tabResultPage1.Name = "tabResultPage1";
            this.tabResultPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabResultPage1.Size = new System.Drawing.Size(399, 190);
            this.tabResultPage1.TabIndex = 0;
            this.tabResultPage1.Text = "Result";
            this.tabResultPage1.UseVisualStyleBackColor = true;
            // 
            // labelResultMessageIncorrectWords
            // 
            this.labelResultMessageIncorrectWords.AutoSize = true;
            this.labelResultMessageIncorrectWords.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResultMessageIncorrectWords.Location = new System.Drawing.Point(6, 136);
            this.labelResultMessageIncorrectWords.Name = "labelResultMessageIncorrectWords";
            this.labelResultMessageIncorrectWords.Size = new System.Drawing.Size(214, 31);
            this.labelResultMessageIncorrectWords.TabIndex = 15;
            this.labelResultMessageIncorrectWords.Text = "Incorrect Words:";
            // 
            // labelIncorrectWords
            // 
            this.labelIncorrectWords.AutoSize = true;
            this.labelIncorrectWords.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelIncorrectWords.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelIncorrectWords.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIncorrectWords.Location = new System.Drawing.Point(277, 136);
            this.labelIncorrectWords.Name = "labelIncorrectWords";
            this.labelIncorrectWords.Size = new System.Drawing.Size(2, 35);
            this.labelIncorrectWords.TabIndex = 14;
            // 
            // labelResultTypedCorrectWords
            // 
            this.labelResultTypedCorrectWords.AutoSize = true;
            this.labelResultTypedCorrectWords.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResultTypedCorrectWords.Location = new System.Drawing.Point(6, 91);
            this.labelResultTypedCorrectWords.Name = "labelResultTypedCorrectWords";
            this.labelResultTypedCorrectWords.Size = new System.Drawing.Size(197, 31);
            this.labelResultTypedCorrectWords.TabIndex = 13;
            this.labelResultTypedCorrectWords.Text = "Correct Words:";
            // 
            // labelResultCorrectWords
            // 
            this.labelResultCorrectWords.AutoSize = true;
            this.labelResultCorrectWords.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelResultCorrectWords.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelResultCorrectWords.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResultCorrectWords.Location = new System.Drawing.Point(277, 91);
            this.labelResultCorrectWords.Name = "labelResultCorrectWords";
            this.labelResultCorrectWords.Size = new System.Drawing.Size(2, 35);
            this.labelResultCorrectWords.TabIndex = 12;
            // 
            // labelResultMessageTypedWords
            // 
            this.labelResultMessageTypedWords.AutoSize = true;
            this.labelResultMessageTypedWords.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResultMessageTypedWords.Location = new System.Drawing.Point(6, 51);
            this.labelResultMessageTypedWords.Name = "labelResultMessageTypedWords";
            this.labelResultMessageTypedWords.Size = new System.Drawing.Size(183, 31);
            this.labelResultMessageTypedWords.TabIndex = 11;
            this.labelResultMessageTypedWords.Text = "Typed Words:";
            // 
            // labelResultTypedWords
            // 
            this.labelResultTypedWords.AutoSize = true;
            this.labelResultTypedWords.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelResultTypedWords.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelResultTypedWords.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResultTypedWords.Location = new System.Drawing.Point(277, 51);
            this.labelResultTypedWords.Name = "labelResultTypedWords";
            this.labelResultTypedWords.Size = new System.Drawing.Size(2, 35);
            this.labelResultTypedWords.TabIndex = 10;
            // 
            // labelResultMessageRealWPM
            // 
            this.labelResultMessageRealWPM.AutoSize = true;
            this.labelResultMessageRealWPM.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResultMessageRealWPM.Location = new System.Drawing.Point(6, 7);
            this.labelResultMessageRealWPM.Name = "labelResultMessageRealWPM";
            this.labelResultMessageRealWPM.Size = new System.Drawing.Size(163, 31);
            this.labelResultMessageRealWPM.TabIndex = 9;
            this.labelResultMessageRealWPM.Text = "Real Speed:";
            // 
            // labelRealResultWPM
            // 
            this.labelRealResultWPM.AutoSize = true;
            this.labelRealResultWPM.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelRealResultWPM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelRealResultWPM.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRealResultWPM.Location = new System.Drawing.Point(277, 7);
            this.labelRealResultWPM.Name = "labelRealResultWPM";
            this.labelRealResultWPM.Size = new System.Drawing.Size(111, 35);
            this.labelRealResultWPM.TabIndex = 6;
            this.labelRealResultWPM.Text = "0 WPM";
            // 
            // tabResultPage2
            // 
            this.tabResultPage2.Controls.Add(this.labelResultMessageCorrectSymbols);
            this.tabResultPage2.Controls.Add(this.labelCorrectSymbols);
            this.tabResultPage2.Controls.Add(this.labelResultMessageIncorrectSymbols);
            this.tabResultPage2.Controls.Add(this.labelResultIncorrectSymbols);
            this.tabResultPage2.Controls.Add(this.labelResultMessageTypedSymbols);
            this.tabResultPage2.Controls.Add(this.labelTypedSymbols);
            this.tabResultPage2.Location = new System.Drawing.Point(4, 22);
            this.tabResultPage2.Name = "tabResultPage2";
            this.tabResultPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabResultPage2.Size = new System.Drawing.Size(399, 190);
            this.tabResultPage2.TabIndex = 1;
            this.tabResultPage2.Text = "Result Details";
            this.tabResultPage2.UseVisualStyleBackColor = true;
            // 
            // labelResultMessageCorrectSymbols
            // 
            this.labelResultMessageCorrectSymbols.AutoSize = true;
            this.labelResultMessageCorrectSymbols.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResultMessageCorrectSymbols.Location = new System.Drawing.Point(6, 59);
            this.labelResultMessageCorrectSymbols.Name = "labelResultMessageCorrectSymbols";
            this.labelResultMessageCorrectSymbols.Size = new System.Drawing.Size(223, 31);
            this.labelResultMessageCorrectSymbols.TabIndex = 21;
            this.labelResultMessageCorrectSymbols.Text = "Correct Symbols:";
            // 
            // labelCorrectSymbols
            // 
            this.labelCorrectSymbols.AutoSize = true;
            this.labelCorrectSymbols.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelCorrectSymbols.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelCorrectSymbols.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCorrectSymbols.Location = new System.Drawing.Point(277, 59);
            this.labelCorrectSymbols.Name = "labelCorrectSymbols";
            this.labelCorrectSymbols.Size = new System.Drawing.Size(2, 35);
            this.labelCorrectSymbols.TabIndex = 20;
            // 
            // labelResultMessageIncorrectSymbols
            // 
            this.labelResultMessageIncorrectSymbols.AutoSize = true;
            this.labelResultMessageIncorrectSymbols.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResultMessageIncorrectSymbols.Location = new System.Drawing.Point(6, 107);
            this.labelResultMessageIncorrectSymbols.Name = "labelResultMessageIncorrectSymbols";
            this.labelResultMessageIncorrectSymbols.Size = new System.Drawing.Size(240, 31);
            this.labelResultMessageIncorrectSymbols.TabIndex = 19;
            this.labelResultMessageIncorrectSymbols.Text = "Incorrect Symbols:";
            // 
            // labelResultIncorrectSymbols
            // 
            this.labelResultIncorrectSymbols.AutoSize = true;
            this.labelResultIncorrectSymbols.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelResultIncorrectSymbols.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelResultIncorrectSymbols.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResultIncorrectSymbols.Location = new System.Drawing.Point(277, 107);
            this.labelResultIncorrectSymbols.Name = "labelResultIncorrectSymbols";
            this.labelResultIncorrectSymbols.Size = new System.Drawing.Size(2, 35);
            this.labelResultIncorrectSymbols.TabIndex = 18;
            // 
            // labelResultMessageTypedSymbols
            // 
            this.labelResultMessageTypedSymbols.AutoSize = true;
            this.labelResultMessageTypedSymbols.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResultMessageTypedSymbols.Location = new System.Drawing.Point(6, 12);
            this.labelResultMessageTypedSymbols.Name = "labelResultMessageTypedSymbols";
            this.labelResultMessageTypedSymbols.Size = new System.Drawing.Size(209, 31);
            this.labelResultMessageTypedSymbols.TabIndex = 17;
            this.labelResultMessageTypedSymbols.Text = "Typed Symbols:";
            // 
            // labelTypedSymbols
            // 
            this.labelTypedSymbols.AutoSize = true;
            this.labelTypedSymbols.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelTypedSymbols.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelTypedSymbols.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTypedSymbols.Location = new System.Drawing.Point(277, 12);
            this.labelTypedSymbols.Name = "labelTypedSymbols";
            this.labelTypedSymbols.Size = new System.Drawing.Size(2, 35);
            this.labelTypedSymbols.TabIndex = 16;
            // 
            // pictureBoxRestartTest
            // 
            this.pictureBoxRestartTest.Image = global::FormsTest.Properties.Resources.Restart;
            this.pictureBoxRestartTest.Location = new System.Drawing.Point(18, 303);
            this.pictureBoxRestartTest.Name = "pictureBoxRestartTest";
            this.pictureBoxRestartTest.Size = new System.Drawing.Size(45, 41);
            this.pictureBoxRestartTest.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxRestartTest.TabIndex = 9;
            this.pictureBoxRestartTest.TabStop = false;
            this.pictureBoxRestartTest.Click += new System.EventHandler(this.pictureBoxRestartTest_Click);
            this.pictureBoxRestartTest.MouseEnter += new System.EventHandler(this.pictureBoxRestartTest_MouseEnter);
            this.pictureBoxRestartTest.MouseLeave += new System.EventHandler(this.pictureBoxRestartTest_MouseLeave);
            // 
            // backgroundWorkerUpdatingRichTextBox
            // 
            this.backgroundWorkerUpdatingRichTextBox.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerUpdatingRichTextBox_DoWork);
            this.backgroundWorkerUpdatingRichTextBox.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerUpdatingRichTextBox_RunWorkerCompleted);
            // 
            // FormTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 348);
            this.Controls.Add(this.pictureBoxRestartTest);
            this.Controls.Add(this.tabControlResult);
            this.Controls.Add(this.labelForRealWPM);
            this.Controls.Add(this.labelCurrentSpeedMessage);
            this.Controls.Add(this.labelForWPM);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.labelMessage);
            this.Controls.Add(this.textBoxForTyping);
            this.Controls.Add(this.richTextBoxForWords);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormTest";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form For Words";
            this.tabControlResult.ResumeLayout(false);
            this.tabResultPage1.ResumeLayout(false);
            this.tabResultPage1.PerformLayout();
            this.tabResultPage2.ResumeLayout(false);
            this.tabResultPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRestartTest)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxForTyping;
        private System.Windows.Forms.Label labelMessage;
        private System.Windows.Forms.RichTextBox richTextBoxForWords;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label labelForWPM;
        private System.Windows.Forms.Label labelCurrentSpeedMessage;
        private System.Windows.Forms.Label labelForRealWPM;
        private System.Windows.Forms.TabControl tabControlResult;
        private System.Windows.Forms.TabPage tabResultPage1;
        private System.Windows.Forms.Label labelResultMessageIncorrectWords;
        private System.Windows.Forms.Label labelIncorrectWords;
        private System.Windows.Forms.Label labelResultTypedCorrectWords;
        private System.Windows.Forms.Label labelResultCorrectWords;
        private System.Windows.Forms.Label labelResultMessageTypedWords;
        private System.Windows.Forms.Label labelResultTypedWords;
        private System.Windows.Forms.Label labelResultMessageRealWPM;
        private System.Windows.Forms.Label labelRealResultWPM;
        private System.Windows.Forms.TabPage tabResultPage2;
        private System.Windows.Forms.Label labelResultMessageCorrectSymbols;
        private System.Windows.Forms.Label labelCorrectSymbols;
        private System.Windows.Forms.Label labelResultMessageIncorrectSymbols;
        private System.Windows.Forms.Label labelResultIncorrectSymbols;
        private System.Windows.Forms.Label labelResultMessageTypedSymbols;
        private System.Windows.Forms.Label labelTypedSymbols;
        private System.Windows.Forms.PictureBox pictureBoxRestartTest;
        private System.Windows.Forms.ToolTip toolTipForTyping;
        private System.ComponentModel.BackgroundWorker backgroundWorkerUpdatingRichTextBox;
    }
}


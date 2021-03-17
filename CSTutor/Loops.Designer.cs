
namespace CSTutor
{
    partial class Loops
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Loops));
            this.codeTextBox = new FastColoredTextBoxNS.FastColoredTextBox();
            this.outputListView = new System.Windows.Forms.ListView();
            this.runButton = new CSTutor.CircularButton();
            this.resetButton = new CSTutor.RoundedEdgeButton();
            this.titleLabel = new System.Windows.Forms.Label();
            this.subtopicListPanel = new System.Windows.Forms.Panel();
            this.whileLoopsButton = new CSTutor.RoundedEdgeButton();
            this.task3Button = new CSTutor.RoundedEdgeButton();
            this.exampleTextBox1 = new FastColoredTextBoxNS.FastColoredTextBox();
            this.subTopic1Label = new System.Windows.Forms.Label();
            this.whileLoopsPanel = new System.Windows.Forms.Panel();
            this.loopsTask2Button = new CSTutor.RoundedEdgeButton();
            this.label1 = new System.Windows.Forms.Label();
            this.loopsTask1Button = new CSTutor.RoundedEdgeButton();
            this.whileLoopsLabel2 = new System.Windows.Forms.Label();
            this.exampleLoopTextBox1 = new FastColoredTextBoxNS.FastColoredTextBox();
            this.WhileLoopsLabel1 = new System.Windows.Forms.Label();
            this.taskLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.codeTextBox)).BeginInit();
            this.subtopicListPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exampleTextBox1)).BeginInit();
            this.whileLoopsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exampleLoopTextBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // codeTextBox
            // 
            this.codeTextBox.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.codeTextBox.AutoScrollMinSize = new System.Drawing.Size(154, 14);
            this.codeTextBox.BackBrush = null;
            this.codeTextBox.CharHeight = 14;
            this.codeTextBox.CharWidth = 8;
            this.codeTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.codeTextBox.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.codeTextBox.IsReplaceMode = false;
            this.codeTextBox.Location = new System.Drawing.Point(530, 104);
            this.codeTextBox.Name = "codeTextBox";
            this.codeTextBox.Paddings = new System.Windows.Forms.Padding(0);
            this.codeTextBox.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.codeTextBox.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("codeTextBox.ServiceColors")));
            this.codeTextBox.Size = new System.Drawing.Size(703, 395);
            this.codeTextBox.TabIndex = 1;
            this.codeTextBox.Text = "fastColoredTextBox1";
            this.codeTextBox.Zoom = 100;
            this.codeTextBox.Load += new System.EventHandler(this.codeTextBox_Load);
            // 
            // outputListView
            // 
            this.outputListView.BackColor = System.Drawing.Color.Black;
            this.outputListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputListView.ForeColor = System.Drawing.Color.White;
            this.outputListView.HideSelection = false;
            this.outputListView.Location = new System.Drawing.Point(530, 522);
            this.outputListView.Name = "outputListView";
            this.outputListView.Size = new System.Drawing.Size(703, 257);
            this.outputListView.TabIndex = 4;
            this.outputListView.UseCompatibleStateImageBehavior = false;
            this.outputListView.View = System.Windows.Forms.View.Details;
            // 
            // runButton
            // 
            this.runButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.runButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.runButton.FlatAppearance.BorderSize = 0;
            this.runButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.runButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.runButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.runButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.runButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.runButton.Location = new System.Drawing.Point(1139, 12);
            this.runButton.Name = "runButton";
            this.runButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.runButton.Size = new System.Drawing.Size(88, 57);
            this.runButton.TabIndex = 6;
            this.runButton.Text = "🏃";
            this.runButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.runButton.UseVisualStyleBackColor = false;
            this.runButton.Click += new System.EventHandler(this.runButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(1029, 12);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(104, 57);
            this.resetButton.TabIndex = 7;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(12, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(105, 37);
            this.titleLabel.TabIndex = 10;
            this.titleLabel.Text = "Loops";
            // 
            // subtopicListPanel
            // 
            this.subtopicListPanel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.subtopicListPanel.BackColor = System.Drawing.Color.PowderBlue;
            this.subtopicListPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.subtopicListPanel.Controls.Add(this.whileLoopsButton);
            this.subtopicListPanel.Controls.Add(this.task3Button);
            this.subtopicListPanel.Controls.Add(this.exampleTextBox1);
            this.subtopicListPanel.Controls.Add(this.subTopic1Label);
            this.subtopicListPanel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.subtopicListPanel.Location = new System.Drawing.Point(-4, 52);
            this.subtopicListPanel.Name = "subtopicListPanel";
            this.subtopicListPanel.Size = new System.Drawing.Size(512, 727);
            this.subtopicListPanel.TabIndex = 11;
            // 
            // whileLoopsButton
            // 
            this.whileLoopsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.whileLoopsButton.Location = new System.Drawing.Point(102, 65);
            this.whileLoopsButton.Name = "whileLoopsButton";
            this.whileLoopsButton.Size = new System.Drawing.Size(299, 62);
            this.whileLoopsButton.TabIndex = 8;
            this.whileLoopsButton.Text = "While Loops";
            this.whileLoopsButton.UseVisualStyleBackColor = true;
            this.whileLoopsButton.Click += new System.EventHandler(this.whileLoopsButton_Click);
            // 
            // task3Button
            // 
            this.task3Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.task3Button.Location = new System.Drawing.Point(61, 915);
            this.task3Button.Name = "task3Button";
            this.task3Button.Size = new System.Drawing.Size(385, 54);
            this.task3Button.TabIndex = 7;
            this.task3Button.Text = "Challenge 3 - Assigning a String";
            this.task3Button.UseVisualStyleBackColor = true;
            // 
            // exampleTextBox1
            // 
            this.exampleTextBox1.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.exampleTextBox1.AutoIndentCharsPatterns = "\r\n^\\s*[\\w\\.]+(\\s\\w+)?\\s*(?<range>=)\\s*(?<range>[^;]+);\r\n^\\s*(case|default)\\s*[^:]" +
    "*(?<range>:)\\s*(?<range>[^;]+);\r\n";
            this.exampleTextBox1.AutoScrollMinSize = new System.Drawing.Size(234, 70);
            this.exampleTextBox1.BackBrush = null;
            this.exampleTextBox1.BracketsHighlightStrategy = FastColoredTextBoxNS.BracketsHighlightStrategy.Strategy2;
            this.exampleTextBox1.CharHeight = 14;
            this.exampleTextBox1.CharWidth = 8;
            this.exampleTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.exampleTextBox1.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.exampleTextBox1.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.exampleTextBox1.IsReplaceMode = false;
            this.exampleTextBox1.Language = FastColoredTextBoxNS.Language.CSharp;
            this.exampleTextBox1.LeftBracket = '(';
            this.exampleTextBox1.LeftBracket2 = '{';
            this.exampleTextBox1.Location = new System.Drawing.Point(17, -140);
            this.exampleTextBox1.Name = "exampleTextBox1";
            this.exampleTextBox1.Paddings = new System.Windows.Forms.Padding(0);
            this.exampleTextBox1.ReadOnly = true;
            this.exampleTextBox1.RightBracket = ')';
            this.exampleTextBox1.RightBracket2 = '}';
            this.exampleTextBox1.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.exampleTextBox1.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("exampleTextBox1.ServiceColors")));
            this.exampleTextBox1.ShowLineNumbers = false;
            this.exampleTextBox1.Size = new System.Drawing.Size(440, 88);
            this.exampleTextBox1.TabIndex = 1;
            this.exampleTextBox1.Text = "  \r\n  int Number = 32;\r\n  bool isTrue = false;\r\n  string Name = \"Thanos\";\r\n  floa" +
    "t decimalNumber = 1.5f;";
            this.exampleTextBox1.Zoom = 100;
            // 
            // subTopic1Label
            // 
            this.subTopic1Label.AutoSize = true;
            this.subTopic1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subTopic1Label.Location = new System.Drawing.Point(13, -299);
            this.subTopic1Label.Name = "subTopic1Label";
            this.subTopic1Label.Size = new System.Drawing.Size(457, 140);
            this.subTopic1Label.TabIndex = 0;
            this.subTopic1Label.Text = resources.GetString("subTopic1Label.Text");
            // 
            // whileLoopsPanel
            // 
            this.whileLoopsPanel.AutoScroll = true;
            this.whileLoopsPanel.BackColor = System.Drawing.Color.PowderBlue;
            this.whileLoopsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.whileLoopsPanel.Controls.Add(this.loopsTask2Button);
            this.whileLoopsPanel.Controls.Add(this.label1);
            this.whileLoopsPanel.Controls.Add(this.loopsTask1Button);
            this.whileLoopsPanel.Controls.Add(this.whileLoopsLabel2);
            this.whileLoopsPanel.Controls.Add(this.exampleLoopTextBox1);
            this.whileLoopsPanel.Controls.Add(this.WhileLoopsLabel1);
            this.whileLoopsPanel.Location = new System.Drawing.Point(4, 49);
            this.whileLoopsPanel.Name = "whileLoopsPanel";
            this.whileLoopsPanel.Size = new System.Drawing.Size(512, 1034);
            this.whileLoopsPanel.TabIndex = 12;
            // 
            // loopsTask2Button
            // 
            this.loopsTask2Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.loopsTask2Button.Location = new System.Drawing.Point(39, 907);
            this.loopsTask2Button.Name = "loopsTask2Button";
            this.loopsTask2Button.Size = new System.Drawing.Size(431, 66);
            this.loopsTask2Button.TabIndex = 5;
            this.loopsTask2Button.Text = "While Loops Challenge - Creating a while loop";
            this.loopsTask2Button.UseVisualStyleBackColor = true;
            this.loopsTask2Button.Click += new System.EventHandler(this.loopsTask2Button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 804);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(415, 80);
            this.label1.TabIndex = 4;
            this.label1.Text = "Now that you have seen how a while loop operates do you\r\nthink that you can try a" +
    "nd create one yourself.\r\n\r\nGive it a go";
            // 
            // loopsTask1Button
            // 
            this.loopsTask1Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.loopsTask1Button.Location = new System.Drawing.Point(39, 715);
            this.loopsTask1Button.Name = "loopsTask1Button";
            this.loopsTask1Button.Size = new System.Drawing.Size(431, 66);
            this.loopsTask1Button.TabIndex = 3;
            this.loopsTask1Button.Text = "While Loops Challenge - Selecting Values\r\n";
            this.loopsTask1Button.UseVisualStyleBackColor = true;
            this.loopsTask1Button.Click += new System.EventHandler(this.loopsTask1Button_Click);
            // 
            // whileLoopsLabel2
            // 
            this.whileLoopsLabel2.AutoSize = true;
            this.whileLoopsLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.whileLoopsLabel2.Location = new System.Drawing.Point(11, 462);
            this.whileLoopsLabel2.Name = "whileLoopsLabel2";
            this.whileLoopsLabel2.Size = new System.Drawing.Size(475, 240);
            this.whileLoopsLabel2.TabIndex = 2;
            this.whileLoopsLabel2.Text = resources.GetString("whileLoopsLabel2.Text");
            // 
            // exampleLoopTextBox1
            // 
            this.exampleLoopTextBox1.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.exampleLoopTextBox1.AutoIndentCharsPatterns = "\r\n^\\s*[\\w\\.]+(\\s\\w+)?\\s*(?<range>=)\\s*(?<range>[^;]+);\r\n^\\s*(case|default)\\s*[^:]" +
    "*(?<range>:)\\s*(?<range>[^;]+);\r\n";
            this.exampleLoopTextBox1.AutoScrollMinSize = new System.Drawing.Size(410, 84);
            this.exampleLoopTextBox1.BackBrush = null;
            this.exampleLoopTextBox1.BracketsHighlightStrategy = FastColoredTextBoxNS.BracketsHighlightStrategy.Strategy2;
            this.exampleLoopTextBox1.CharHeight = 14;
            this.exampleLoopTextBox1.CharWidth = 8;
            this.exampleLoopTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.exampleLoopTextBox1.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.exampleLoopTextBox1.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.exampleLoopTextBox1.IsReplaceMode = false;
            this.exampleLoopTextBox1.Language = FastColoredTextBoxNS.Language.CSharp;
            this.exampleLoopTextBox1.LeftBracket = '(';
            this.exampleLoopTextBox1.LeftBracket2 = '{';
            this.exampleLoopTextBox1.Location = new System.Drawing.Point(14, 355);
            this.exampleLoopTextBox1.Name = "exampleLoopTextBox1";
            this.exampleLoopTextBox1.Paddings = new System.Windows.Forms.Padding(0);
            this.exampleLoopTextBox1.RightBracket = ')';
            this.exampleLoopTextBox1.RightBracket2 = '}';
            this.exampleLoopTextBox1.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.exampleLoopTextBox1.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("exampleLoopTextBox1.ServiceColors")));
            this.exampleLoopTextBox1.ShowLineNumbers = false;
            this.exampleLoopTextBox1.Size = new System.Drawing.Size(483, 93);
            this.exampleLoopTextBox1.TabIndex = 1;
            this.exampleLoopTextBox1.Text = "int i = 0\r\nwhile (i < 20)\r\n{\r\n    Console.Write(\"The current iteration is \" + i);" +
    "\r\n    i++;\r\n}";
            this.exampleLoopTextBox1.Zoom = 100;
            // 
            // WhileLoopsLabel1
            // 
            this.WhileLoopsLabel1.AutoSize = true;
            this.WhileLoopsLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WhileLoopsLabel1.Location = new System.Drawing.Point(16, 23);
            this.WhileLoopsLabel1.Name = "WhileLoopsLabel1";
            this.WhileLoopsLabel1.Size = new System.Drawing.Size(487, 320);
            this.WhileLoopsLabel1.TabIndex = 0;
            this.WhileLoopsLabel1.Text = resources.GetString("WhileLoopsLabel1.Text");
            // 
            // taskLabel
            // 
            this.taskLabel.AutoSize = true;
            this.taskLabel.Location = new System.Drawing.Point(539, 52);
            this.taskLabel.Name = "taskLabel";
            this.taskLabel.Size = new System.Drawing.Size(87, 13);
            this.taskLabel.TabIndex = 13;
            this.taskLabel.Text = "No task selected\r\n";
            // 
            // Loops
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1248, 828);
            this.Controls.Add(this.taskLabel);
            this.Controls.Add(this.whileLoopsPanel);
            this.Controls.Add(this.subtopicListPanel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.runButton);
            this.Controls.Add(this.outputListView);
            this.Controls.Add(this.codeTextBox);
            this.Name = "Loops";
            this.Text = "Loops";
            ((System.ComponentModel.ISupportInitialize)(this.codeTextBox)).EndInit();
            this.subtopicListPanel.ResumeLayout(false);
            this.subtopicListPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exampleTextBox1)).EndInit();
            this.whileLoopsPanel.ResumeLayout(false);
            this.whileLoopsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exampleLoopTextBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FastColoredTextBoxNS.FastColoredTextBox codeTextBox;
        private System.Windows.Forms.ListView outputListView;
        private CircularButton runButton;
        private RoundedEdgeButton resetButton;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Panel subtopicListPanel;
        private RoundedEdgeButton whileLoopsButton;
        private RoundedEdgeButton task3Button;
        private FastColoredTextBoxNS.FastColoredTextBox exampleTextBox1;
        private System.Windows.Forms.Label subTopic1Label;
        private System.Windows.Forms.Panel whileLoopsPanel;
        private System.Windows.Forms.Label WhileLoopsLabel1;
        private FastColoredTextBoxNS.FastColoredTextBox exampleLoopTextBox1;
        private System.Windows.Forms.Label whileLoopsLabel2;
        private RoundedEdgeButton loopsTask1Button;
        private System.Windows.Forms.Label taskLabel;
        private RoundedEdgeButton loopsTask2Button;
        private System.Windows.Forms.Label label1;
    }
}
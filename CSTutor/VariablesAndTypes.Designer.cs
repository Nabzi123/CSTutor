
namespace CSTutor
{
    partial class VariablesAndTypes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VariablesAndTypes));
            this.codeTextBox = new FastColoredTextBoxNS.FastColoredTextBox();
            this.outputListView = new System.Windows.Forms.ListView();
            this.runButton = new CSTutor.CircularButton();
            this.resetButton = new CSTutor.RoundedEdgeButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.subTopic1Button = new CSTutor.RoundedEdgeButton();
            this.titleLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.task3Button = new CSTutor.RoundedEdgeButton();
            this.subTopic1Label4 = new System.Windows.Forms.Label();
            this.task2Button = new CSTutor.RoundedEdgeButton();
            this.subTopic1Label3 = new System.Windows.Forms.Label();
            this.challenge1Button = new CSTutor.RoundedEdgeButton();
            this.subTopic1Label2 = new System.Windows.Forms.Label();
            this.exampleTextBox1 = new FastColoredTextBoxNS.FastColoredTextBox();
            this.subTopic1Label = new System.Windows.Forms.Label();
            this.taskLabel = new System.Windows.Forms.Label();
            this.subTopic1Label1 = new System.Windows.Forms.Label();
            this.exampleCodeBox = new FastColoredTextBoxNS.FastColoredTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.codeTextBox)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exampleTextBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exampleCodeBox)).BeginInit();
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
            this.codeTextBox.AutoScrollMinSize = new System.Drawing.Size(179, 14);
            this.codeTextBox.BackBrush = null;
            this.codeTextBox.CharHeight = 14;
            this.codeTextBox.CharWidth = 8;
            this.codeTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.codeTextBox.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.codeTextBox.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.codeTextBox.IsReplaceMode = false;
            this.codeTextBox.Location = new System.Drawing.Point(530, 104);
            this.codeTextBox.Name = "codeTextBox";
            this.codeTextBox.Paddings = new System.Windows.Forms.Padding(0);
            this.codeTextBox.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.codeTextBox.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("codeTextBox.ServiceColors")));
            this.codeTextBox.Size = new System.Drawing.Size(703, 395);
            this.codeTextBox.TabIndex = 0;
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
            this.outputListView.TabIndex = 3;
            this.outputListView.UseCompatibleStateImageBehavior = false;
            this.outputListView.View = System.Windows.Forms.View.List;
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
            this.runButton.TabIndex = 7;
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
            this.resetButton.TabIndex = 8;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.PowderBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.subTopic1Button);
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(19, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(490, 727);
            this.panel1.TabIndex = 7;
            // 
            // subTopic1Button
            // 
            this.subTopic1Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subTopic1Button.Location = new System.Drawing.Point(56, 51);
            this.subTopic1Button.Name = "subTopic1Button";
            this.subTopic1Button.Size = new System.Drawing.Size(377, 60);
            this.subTopic1Button.TabIndex = 0;
            this.subTopic1Button.Text = "Assigning Variables";
            this.subTopic1Button.UseVisualStyleBackColor = true;
            this.subTopic1Button.Click += new System.EventHandler(this.subTopic1Button_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(30, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(309, 37);
            this.titleLabel.TabIndex = 9;
            this.titleLabel.Text = "Variables and Types";
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel2.AutoScroll = true;
            this.panel2.BackColor = System.Drawing.Color.PowderBlue;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.exampleCodeBox);
            this.panel2.Controls.Add(this.subTopic1Label1);
            this.panel2.Controls.Add(this.task3Button);
            this.panel2.Controls.Add(this.subTopic1Label4);
            this.panel2.Controls.Add(this.task2Button);
            this.panel2.Controls.Add(this.subTopic1Label3);
            this.panel2.Controls.Add(this.challenge1Button);
            this.panel2.Controls.Add(this.subTopic1Label2);
            this.panel2.Controls.Add(this.exampleTextBox1);
            this.panel2.Controls.Add(this.subTopic1Label);
            this.panel2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Location = new System.Drawing.Point(19, 52);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(505, 727);
            this.panel2.TabIndex = 8;
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
            this.task3Button.Click += new System.EventHandler(this.task3Button_Click);
            // 
            // subTopic1Label4
            // 
            this.subTopic1Label4.AutoSize = true;
            this.subTopic1Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subTopic1Label4.Location = new System.Drawing.Point(17, 686);
            this.subTopic1Label4.Name = "subTopic1Label4";
            this.subTopic1Label4.Size = new System.Drawing.Size(429, 220);
            this.subTopic1Label4.TabIndex = 6;
            this.subTopic1Label4.Text = resources.GetString("subTopic1Label4.Text");
            // 
            // task2Button
            // 
            this.task2Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.task2Button.Location = new System.Drawing.Point(55, 603);
            this.task2Button.Name = "task2Button";
            this.task2Button.Size = new System.Drawing.Size(384, 60);
            this.task2Button.TabIndex = 5;
            this.task2Button.Text = "Challenge 2 - Assigning a Bool";
            this.task2Button.UseVisualStyleBackColor = true;
            this.task2Button.Click += new System.EventHandler(this.task2Button_Click);
            // 
            // subTopic1Label3
            // 
            this.subTopic1Label3.AutoSize = true;
            this.subTopic1Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subTopic1Label3.Location = new System.Drawing.Point(17, 419);
            this.subTopic1Label3.Name = "subTopic1Label3";
            this.subTopic1Label3.Size = new System.Drawing.Size(393, 160);
            this.subTopic1Label3.TabIndex = 4;
            this.subTopic1Label3.Text = resources.GetString("subTopic1Label3.Text");
            // 
            // challenge1Button
            // 
            this.challenge1Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.challenge1Button.Location = new System.Drawing.Point(55, 341);
            this.challenge1Button.Name = "challenge1Button";
            this.challenge1Button.Size = new System.Drawing.Size(391, 60);
            this.challenge1Button.TabIndex = 3;
            this.challenge1Button.Text = "Challenge 1 - Assigning an Int";
            this.challenge1Button.UseVisualStyleBackColor = true;
            this.challenge1Button.Click += new System.EventHandler(this.task1Button_Click);
            // 
            // subTopic1Label2
            // 
            this.subTopic1Label2.AutoSize = true;
            this.subTopic1Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subTopic1Label2.Location = new System.Drawing.Point(10, 203);
            this.subTopic1Label2.Name = "subTopic1Label2";
            this.subTopic1Label2.Size = new System.Drawing.Size(474, 120);
            this.subTopic1Label2.TabIndex = 2;
            this.subTopic1Label2.Text = resources.GetString("subTopic1Label2.Text");
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
            // taskLabel
            // 
            this.taskLabel.AutoSize = true;
            this.taskLabel.Location = new System.Drawing.Point(530, 62);
            this.taskLabel.Name = "taskLabel";
            this.taskLabel.Size = new System.Drawing.Size(87, 13);
            this.taskLabel.TabIndex = 10;
            this.taskLabel.Text = "No task selected";
            // 
            // subTopic1Label1
            // 
            this.subTopic1Label1.AutoSize = true;
            this.subTopic1Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subTopic1Label1.Location = new System.Drawing.Point(18, 10);
            this.subTopic1Label1.Name = "subTopic1Label1";
            this.subTopic1Label1.Size = new System.Drawing.Size(414, 100);
            this.subTopic1Label1.TabIndex = 8;
            this.subTopic1Label1.Text = "C# is a strongly typed programming language\r\nThis means when a variable is assign" +
    "ed a typed it cannot\r\nbe changed\r\n\r\nBelow are some examples of variables with di" +
    "fferent types\r\n";
            // 
            // exampleCodeBox
            // 
            this.exampleCodeBox.AutoCompleteBracketsList = new char[] {
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
            this.exampleCodeBox.AutoIndentCharsPatterns = "\r\n^\\s*[\\w\\.]+(\\s\\w+)?\\s*(?<range>=)\\s*(?<range>[^;]+);\r\n^\\s*(case|default)\\s*[^:]" +
    "*(?<range>:)\\s*(?<range>[^;]+);\r\n";
            this.exampleCodeBox.AutoScrollMinSize = new System.Drawing.Size(226, 56);
            this.exampleCodeBox.BackBrush = null;
            this.exampleCodeBox.BracketsHighlightStrategy = FastColoredTextBoxNS.BracketsHighlightStrategy.Strategy2;
            this.exampleCodeBox.CharHeight = 14;
            this.exampleCodeBox.CharWidth = 8;
            this.exampleCodeBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.exampleCodeBox.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.exampleCodeBox.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.exampleCodeBox.IsReplaceMode = false;
            this.exampleCodeBox.Language = FastColoredTextBoxNS.Language.CSharp;
            this.exampleCodeBox.LeftBracket = '(';
            this.exampleCodeBox.LeftBracket2 = '{';
            this.exampleCodeBox.Location = new System.Drawing.Point(22, 126);
            this.exampleCodeBox.Name = "exampleCodeBox";
            this.exampleCodeBox.Paddings = new System.Windows.Forms.Padding(0);
            this.exampleCodeBox.RightBracket = ')';
            this.exampleCodeBox.RightBracket2 = '}';
            this.exampleCodeBox.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.exampleCodeBox.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("exampleCodeBox.ServiceColors")));
            this.exampleCodeBox.ShowLineNumbers = false;
            this.exampleCodeBox.Size = new System.Drawing.Size(460, 64);
            this.exampleCodeBox.TabIndex = 9;
            this.exampleCodeBox.Text = " int number = 15;\r\n bool isTrue = false;\r\n string Name = \"Thanos\";\r\n float decima" +
    "lNumber = 1.5f;";
            this.exampleCodeBox.Zoom = 100;
            // 
            // VariablesAndTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1248, 828);
            this.Controls.Add(this.taskLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.runButton);
            this.Controls.Add(this.outputListView);
            this.Controls.Add(this.codeTextBox);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "VariablesAndTypes";
            this.Text = "VariablesAndTypes";
            ((System.ComponentModel.ISupportInitialize)(this.codeTextBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exampleTextBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exampleCodeBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FastColoredTextBoxNS.FastColoredTextBox codeTextBox;
        private System.Windows.Forms.ListView outputListView;
        private CircularButton runButton;
        private RoundedEdgeButton resetButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label titleLabel;
        private RoundedEdgeButton subTopic1Button;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label subTopic1Label;
        private System.Windows.Forms.Label subTopic1Label2;
        private FastColoredTextBoxNS.FastColoredTextBox exampleTextBox1;
        private System.Windows.Forms.Label taskLabel;
        private RoundedEdgeButton challenge1Button;
        private RoundedEdgeButton task2Button;
        private System.Windows.Forms.Label subTopic1Label3;
        private System.Windows.Forms.Label subTopic1Label4;
        private RoundedEdgeButton task3Button;
        private System.Windows.Forms.Label subTopic1Label1;
        private FastColoredTextBoxNS.FastColoredTextBox exampleCodeBox;
    }
}
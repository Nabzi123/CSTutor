
namespace CSTutor
{
    partial class Test_Code
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Test_Code));
            this.codeTextBox = new FastColoredTextBoxNS.FastColoredTextBox();
            this.runButton = new CSTutor.CircularButton();
            this.outputListView = new System.Windows.Forms.ListView();
            this.titleLabel = new System.Windows.Forms.Label();
            this.outputTextLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.codeTextBox)).BeginInit();
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
            this.codeTextBox.AutoIndentCharsPatterns = "\r\n^\\s*[\\w\\.]+(\\s\\w+)?\\s*(?<range>=)\\s*(?<range>[^;]+);\r\n^\\s*(case|default)\\s*[^:]" +
    "*(?<range>:)\\s*(?<range>[^;]+);\r\n";
            this.codeTextBox.AutoScrollMinSize = new System.Drawing.Size(187, 14);
            this.codeTextBox.BackBrush = null;
            this.codeTextBox.BracketsHighlightStrategy = FastColoredTextBoxNS.BracketsHighlightStrategy.Strategy2;
            this.codeTextBox.CharHeight = 14;
            this.codeTextBox.CharWidth = 8;
            this.codeTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.codeTextBox.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.codeTextBox.IsReplaceMode = false;
            this.codeTextBox.Language = FastColoredTextBoxNS.Language.CSharp;
            this.codeTextBox.LeftBracket = '(';
            this.codeTextBox.LeftBracket2 = '{';
            this.codeTextBox.Location = new System.Drawing.Point(46, 95);
            this.codeTextBox.Name = "codeTextBox";
            this.codeTextBox.Paddings = new System.Windows.Forms.Padding(0);
            this.codeTextBox.RightBracket = ')';
            this.codeTextBox.RightBracket2 = '}';
            this.codeTextBox.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.codeTextBox.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("codeTextBox.ServiceColors")));
            this.codeTextBox.Size = new System.Drawing.Size(1151, 384);
            this.codeTextBox.TabIndex = 0;
            this.codeTextBox.Text = "fastColouredTextBox1";
            this.codeTextBox.Zoom = 100;
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
            this.runButton.Location = new System.Drawing.Point(1104, 11);
            this.runButton.Name = "runButton";
            this.runButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.runButton.Size = new System.Drawing.Size(93, 57);
            this.runButton.TabIndex = 6;
            this.runButton.Text = "🏃";
            this.runButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.runButton.UseVisualStyleBackColor = false;
            // 
            // outputListView
            // 
            this.outputListView.BackColor = System.Drawing.Color.Black;
            this.outputListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputListView.ForeColor = System.Drawing.Color.White;
            this.outputListView.HideSelection = false;
            this.outputListView.Location = new System.Drawing.Point(46, 517);
            this.outputListView.Name = "outputListView";
            this.outputListView.Size = new System.Drawing.Size(1151, 280);
            this.outputListView.TabIndex = 7;
            this.outputListView.UseCompatibleStateImageBehavior = false;
            this.outputListView.View = System.Windows.Forms.View.List;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(48, 22);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(164, 37);
            this.titleLabel.TabIndex = 11;
            this.titleLabel.Text = "Test Code";
            // 
            // outputTextLabel
            // 
            this.outputTextLabel.AutoSize = true;
            this.outputTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputTextLabel.Location = new System.Drawing.Point(43, 492);
            this.outputTextLabel.Name = "outputTextLabel";
            this.outputTextLabel.Size = new System.Drawing.Size(120, 20);
            this.outputTextLabel.TabIndex = 12;
            this.outputTextLabel.Text = "Console Output";
            // 
            // Test_Code
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1248, 828);
            this.Controls.Add(this.outputTextLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.outputListView);
            this.Controls.Add(this.runButton);
            this.Controls.Add(this.codeTextBox);
            this.Name = "Test_Code";
            this.Text = "Test_Code";
            ((System.ComponentModel.ISupportInitialize)(this.codeTextBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FastColoredTextBoxNS.FastColoredTextBox codeTextBox;
        private CircularButton runButton;
        private System.Windows.Forms.ListView outputListView;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label outputTextLabel;
    }
}
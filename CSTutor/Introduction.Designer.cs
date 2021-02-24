
namespace CSTutor
{
    partial class Introduction
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Introduction));
            this.codeTextBox = new FastColoredTextBoxNS.FastColoredTextBox();
            this.outputListView = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.runButton = new CSTutor.CircularButton();
            this.resetButton = new CSTutor.RoundedEdgeButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.task1Button = new CSTutor.RoundedEdgeButton();
            this.taskLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.codeTextBox)).BeginInit();
            this.panel1.SuspendLayout();
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
            this.codeTextBox.IsReplaceMode = false;
            this.codeTextBox.Location = new System.Drawing.Point(431, 76);
            this.codeTextBox.Name = "codeTextBox";
            this.codeTextBox.Paddings = new System.Windows.Forms.Padding(0);
            this.codeTextBox.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.codeTextBox.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("codeTextBox.ServiceColors")));
            this.codeTextBox.Size = new System.Drawing.Size(796, 395);
            this.codeTextBox.TabIndex = 0;
            this.codeTextBox.Text = "fastColoredTextBox1";
            this.codeTextBox.Zoom = 100;
            // 
            // outputListView
            // 
            this.outputListView.BackColor = System.Drawing.Color.Black;
            this.outputListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputListView.ForeColor = System.Drawing.Color.White;
            this.outputListView.HideSelection = false;
            this.outputListView.Location = new System.Drawing.Point(431, 491);
            this.outputListView.Name = "outputListView";
            this.outputListView.Size = new System.Drawing.Size(796, 299);
            this.outputListView.TabIndex = 3;
            this.outputListView.UseCompatibleStateImageBehavior = false;
            this.outputListView.View = System.Windows.Forms.View.Details;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 37);
            this.label1.TabIndex = 4;
            this.label1.Text = "Introduction";
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
            this.runButton.TabIndex = 5;
            this.runButton.Text = "🏃";
            this.runButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.runButton.UseVisualStyleBackColor = false;
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(1029, 12);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(104, 57);
            this.resetButton.TabIndex = 6;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.roundedEdgeButton1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.task1Button);
            this.panel1.Location = new System.Drawing.Point(19, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(389, 764);
            this.panel1.TabIndex = 7;
            // 
            // task1Button
            // 
            this.task1Button.Location = new System.Drawing.Point(32, 45);
            this.task1Button.Name = "task1Button";
            this.task1Button.Size = new System.Drawing.Size(328, 57);
            this.task1Button.TabIndex = 0;
            this.task1Button.Text = "Getting Started";
            this.task1Button.UseVisualStyleBackColor = true;
            this.task1Button.Click += new System.EventHandler(this.task1Button_Click);
            // 
            // taskLabel
            // 
            this.taskLabel.AutoSize = true;
            this.taskLabel.Location = new System.Drawing.Point(443, 52);
            this.taskLabel.Name = "taskLabel";
            this.taskLabel.Size = new System.Drawing.Size(35, 13);
            this.taskLabel.TabIndex = 8;
            this.taskLabel.Text = "label2";
            // 
            // Introduction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1248, 828);
            this.Controls.Add(this.taskLabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.runButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.outputListView);
            this.Controls.Add(this.codeTextBox);
            this.Name = "Introduction";
            this.Text = "Introduction";
            ((System.ComponentModel.ISupportInitialize)(this.codeTextBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FastColoredTextBoxNS.FastColoredTextBox codeTextBox;
        private System.Windows.Forms.ListView outputListView;
        private System.Windows.Forms.Label label1;
        private CircularButton runButton;
        private RoundedEdgeButton resetButton;
        private System.Windows.Forms.Panel panel1;
        private RoundedEdgeButton task1Button;
        private System.Windows.Forms.Label taskLabel;
    }
}
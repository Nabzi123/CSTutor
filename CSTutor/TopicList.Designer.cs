
namespace CSTutor
{
    partial class TopicList
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.topic1Button = new CSTutor.RoundedEdgeButton();
            this.variableButton = new CSTutor.RoundedEdgeButton();
            this.conditionalButton = new CSTutor.RoundedEdgeButton();
            this.loopsButton = new CSTutor.RoundedEdgeButton();
            this.testCodeButton = new CSTutor.RoundedEdgeButton();
            this.topicListLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.topic1Button);
            this.panel1.Controls.Add(this.variableButton);
            this.panel1.Controls.Add(this.conditionalButton);
            this.panel1.Controls.Add(this.loopsButton);
            this.panel1.Controls.Add(this.testCodeButton);
            this.panel1.Location = new System.Drawing.Point(2, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(404, 589);
            this.panel1.TabIndex = 8;
            // 
            // topic1Button
            // 
            this.topic1Button.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.topic1Button.FlatAppearance.BorderSize = 0;
            this.topic1Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topic1Button.Location = new System.Drawing.Point(22, 3);
            this.topic1Button.Name = "topic1Button";
            this.topic1Button.Size = new System.Drawing.Size(379, 57);
            this.topic1Button.TabIndex = 6;
            this.topic1Button.Text = "Introduction";
            this.topic1Button.UseVisualStyleBackColor = true;
            // 
            // variableButton
            // 
            this.variableButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.variableButton.Location = new System.Drawing.Point(22, 93);
            this.variableButton.Name = "variableButton";
            this.variableButton.Size = new System.Drawing.Size(379, 57);
            this.variableButton.TabIndex = 7;
            this.variableButton.Text = "Variables and Types";
            this.variableButton.UseVisualStyleBackColor = true;
            this.variableButton.Click += new System.EventHandler(this.variableButton_Click);
            // 
            // conditionalButton
            // 
            this.conditionalButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conditionalButton.Location = new System.Drawing.Point(22, 186);
            this.conditionalButton.Name = "conditionalButton";
            this.conditionalButton.Size = new System.Drawing.Size(379, 57);
            this.conditionalButton.TabIndex = 7;
            this.conditionalButton.Text = "Conditional Statements";
            this.conditionalButton.UseVisualStyleBackColor = true;
            this.conditionalButton.Click += new System.EventHandler(this.conditionalButton_Click);
            // 
            // loopsButton
            // 
            this.loopsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loopsButton.Location = new System.Drawing.Point(22, 279);
            this.loopsButton.Name = "loopsButton";
            this.loopsButton.Size = new System.Drawing.Size(379, 57);
            this.loopsButton.TabIndex = 7;
            this.loopsButton.Text = "Loops";
            this.loopsButton.UseVisualStyleBackColor = true;
            this.loopsButton.Click += new System.EventHandler(this.loopsButton_Click);
            // 
            // testCodeButton
            // 
            this.testCodeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.testCodeButton.Location = new System.Drawing.Point(22, 375);
            this.testCodeButton.Name = "testCodeButton";
            this.testCodeButton.Size = new System.Drawing.Size(379, 57);
            this.testCodeButton.TabIndex = 7;
            this.testCodeButton.Text = "Test Code";
            this.testCodeButton.UseVisualStyleBackColor = true;
            // 
            // topicListLabel
            // 
            this.topicListLabel.AutoSize = true;
            this.topicListLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topicListLabel.Location = new System.Drawing.Point(139, 9);
            this.topicListLabel.Name = "topicListLabel";
            this.topicListLabel.Size = new System.Drawing.Size(131, 31);
            this.topicListLabel.TabIndex = 9;
            this.topicListLabel.Text = "Topic List";
            // 
            // TopicList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(419, 644);
            this.Controls.Add(this.topicListLabel);
            this.Controls.Add(this.panel1);
            this.Name = "TopicList";
            this.Text = "TopicListForm";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private RoundedEdgeButton topic1Button;
        private RoundedEdgeButton testCodeButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label topicListLabel;
        private RoundedEdgeButton variableButton;
        private RoundedEdgeButton conditionalButton;
        private RoundedEdgeButton loopsButton;
    }
}
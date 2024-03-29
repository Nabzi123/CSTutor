﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSTutor
{
    public partial class TopicList : Form
    {
        public TopicList()
        {
            InitializeComponent();
        }

        private void topic1Button_Click(Object sender, EventArgs e)
        {
            Form newTopic = new Introduction();
            newTopic.Show();
        }

        private void testCodeButton_Click(Object sender, EventArgs e)
        {
            Form testCode = new Test_Code();
            testCode.Show();
        }

        private void variableButton_Click(object sender, EventArgs e)
        {
            Form variablesAndTypes = new VariablesAndTypes();
            variablesAndTypes.Show();
        }

        private void conditionalButton_Click(object sender, EventArgs e)
        {
            Form conditionals = new Conditionals();
            conditionals.Show();
        }

        private void loopsButton_Click(object sender, EventArgs e)
        {
            Form loopsForm = new Loops();
            loopsForm.Show();
        }
    }
}

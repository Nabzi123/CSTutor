using System;
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
            topic1Button.Click += new EventHandler(topic1Button_Click);
            testCodeButton.Click += new EventHandler(testCodeButton_Click);
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

        }

        private void conditionalButton_Click(object sender, EventArgs e)
        {

        }

        private void loopsButton_Click(object sender, EventArgs e)
        {

        }
    }
}

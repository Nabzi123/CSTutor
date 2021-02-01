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
    public partial class CS_Tutor_Start : Form
    {
        public CS_Tutor_Start()
        {
            InitializeComponent();
            startButton.Click += new EventHandler(startButton_Click);
        }

        private void startButton_Click(Object sender, EventArgs e)
        {
            Form newForm = new TopicList();
            newForm.Show();
            this.Hide();
        }
    }
}

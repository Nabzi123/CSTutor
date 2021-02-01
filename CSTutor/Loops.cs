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
    public partial class Loops : Form
    {
        public Loops()
        {
            InitializeComponent();
        }

        private void codeTextBox_Load(object sender, EventArgs e)
        {
            codeTextBox.Language = FastColoredTextBoxNS.Language.CSharp;
            codeTextBox.Text = @"using System;
namespace LoopsNS
{
    public static class LoopsClass
    {
        public static void LoopsMethod()
        {
            // Write Code Here


        }
    }
}";
        }

        private void runButton_Click(object sender, EventArgs e)
        {

        }

        private void resetButton_Click(object sender, EventArgs e)
        {

        }
    }
}

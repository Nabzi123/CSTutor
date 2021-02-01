using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.CodeDom.Compiler;
using Microsoft.CSharp;
using System.Reflection;
using System.IO;


namespace CSTutor
{
    public partial class Introduction : Form
    {
        private string expectedOutput;


        public Introduction()
        {
            InitializeComponent();

            fastColoredTextBox1.Load += new EventHandler(fastColouredTextBox1_Load);
            runButton.Click += new EventHandler(runButton_Click);
            listView1.View = View.List;
        }

  


        private void fastColouredTextBox1_Load(Object sender, EventArgs e)
        {
            fastColoredTextBox1.Language = FastColoredTextBoxNS.Language.CSharp;
            fastColoredTextBox1.Text = @"using System;

namespace TutorNS
{
    public static class TutorCode
    {
        public static void TutorMethod()
        {
            //Write code here
            


        }
    }
}";
        }


        private void runButton_Click(Object sender, EventArgs e)
        {

            var originalOutput = Console.Out;
            var writer = new StringWriter();

            Console.SetOut(writer);

            CSharpCodeProvider provider = new CSharpCodeProvider();
            CompilerParameters parameters = new CompilerParameters();


            parameters.ReferencedAssemblies.Add("System.dll");
            parameters.ReferencedAssemblies.Add("mscorlib.dll");
            parameters.GenerateInMemory = true;
            parameters.GenerateExecutable = false;

            listView1.Items.Clear();


            CompilerResults results = provider.CompileAssemblyFromSource(parameters, fastColoredTextBox1.Text);

            if (!results.Errors.HasErrors)
            {
                var cls = results.CompiledAssembly.GetType("TutorNS.TutorCode");
                var method = cls.GetMethod("TutorMethod", BindingFlags.Static | BindingFlags.Public);
                method.Invoke(null, null);

                writer.Flush();

                Console.SetOut(originalOutput);

                listView1.ForeColor = Color.LimeGreen;

                string userOutputText = writer.GetStringBuilder().ToString();

                expectedOutput = "Hello, World!";

                if (userOutputText != expectedOutput)
                {
                    listView1.Items.Add("The code compiled correctly but the output was incorrect: " + userOutputText);
                    listView1.Items.Add(" ");
                    listView1.Items.Add("The expected output is: " + expectedOutput);
                }
                else
                {
                    listView1.Items.Add("Success");
                    fastColoredTextBox1.ReadOnly = true;
                    fastColoredTextBox1.BackColor = Color.LightGray;
                    runButton.Enabled = false;
                    
                }

            }
            else
            {
                foreach(CompilerError error in results.Errors)
                {
                    Console.WriteLine(error.ErrorText);

                    writer.Flush();

                    listView1.ForeColor = Color.Red;

                    listView1.Items.Add(writer.GetStringBuilder().ToString());
                }
            }
            





        }

        private void roundedEdgeButton1_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.ReadOnly = false;
            fastColoredTextBox1.BackColor = Color.White;
            runButton.Enabled = true;
            fastColoredTextBox1.Text = @"using System;

namespace TutorNS
{
    public static class TutorCode
    {
        public static void TutorMethod()
        {
            //Write code here
            

        }
    }
}";
        }
    }
}

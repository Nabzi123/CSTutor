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
using System.Data.OleDb;


namespace CSTutor
{
    public partial class Introduction : Form
    {
        private string expectedOutput;
        private int selectedTask;

        public Introduction()
        {
            InitializeComponent();

            codeTextBox.Load += new EventHandler(fastColouredTextBox1_Load);
            runButton.Click += new EventHandler(runButton_Click);
            outputListView.View = View.List;
        }




        private void fastColouredTextBox1_Load(Object sender, EventArgs e)
        {
            codeTextBox.Language = FastColoredTextBoxNS.Language.CSharp;
            codeTextBox.Text = @"//Code Will be entered here";


            for (int i = 0; i < codeTextBox.LinesCount; i++)
            {
                if (!string.IsNullOrWhiteSpace(codeTextBox.GetLineText(i)))
                {
                    codeTextBox.GetLine(i).ReadOnly = true;
                }
            }
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

            outputListView.Items.Clear();


            CompilerResults results = provider.CompileAssemblyFromSource(parameters, codeTextBox.Text);

            if (!results.Errors.HasErrors)
            {
                var cls = results.CompiledAssembly.GetType("TutorNS.TutorCode");
                var method = cls.GetMethod("TutorMethod", BindingFlags.Static | BindingFlags.Public);
                method.Invoke(null, null);

                writer.Flush();

                Console.SetOut(originalOutput);

                outputListView.ForeColor = Color.LimeGreen;

                string userOutputText = writer.GetStringBuilder().ToString();

                expectedOutput = "Hello, World!";

                if (userOutputText != expectedOutput)
                {
                    outputListView.Items.Add("The code compiled correctly but the output was incorrect: " + userOutputText);
                    outputListView.Items.Add(" ");
                    outputListView.Items.Add("The expected output is: " + expectedOutput);
                }
                else
                {
                    outputListView.Items.Add("Success");
                    codeTextBox.ReadOnly = true;
                    codeTextBox.BackColor = Color.LightGray;
                    runButton.Enabled = false;
                    
                }

            }
            else
            {
                foreach(CompilerError error in results.Errors)
                {
                    Console.WriteLine(error.ErrorText);

                    writer.Flush();

                    outputListView.ForeColor = Color.Red;

                    outputListView.Items.Add(writer.GetStringBuilder().ToString());
                }
            }
            





        }

        private void roundedEdgeButton1_Click(object sender, EventArgs e)
        {
            codeTextBox.ReadOnly = false;
            codeTextBox.BackColor = Color.White;
            runButton.Enabled = true;
            codeTextBox.Text = @"using System;

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

            for(int i = 0; i < codeTextBox.LinesCount; i++)
            {
                if(!string.IsNullOrWhiteSpace(codeTextBox.GetLineText(i)))
                {
                    codeTextBox.GetLine(i).ReadOnly = true;
                }
            }

        }

        private void task1Button_Click(object sender, EventArgs e)
        {
            selectedTask = 1;
            OleDbConnection connection = new OleDbConnection();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source = ProjectDatabase.accdb;
Persist Security Info = False; ";
            connection.Open();

            OleDbCommand command = new OleDbCommand("SELECT TaskString FROM Introduction WHERE TaskID = 1", connection);
            OleDbDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                taskLabel.Text = reader[0].ToString();
            }

            connection.Close();

            connection.Open();

            command = new OleDbCommand("SELECT ConsoleText FROM Introduction WHERE TaskID = 1", connection);
            reader = command.ExecuteReader();

            while (reader.Read())
            {
                codeTextBox.Text = reader[0].ToString();
                codeTextBox.SelectAll();
                codeTextBox.DoAutoIndent();
            }

            connection.Close();

            for (int i = 0; i < codeTextBox.LinesCount; i++)
            {
                if(!string.IsNullOrWhiteSpace(codeTextBox.GetLineText(i)))
                {
                    codeTextBox.GetLine(i).ReadOnly = true;
                }
            }

        }
    }
}

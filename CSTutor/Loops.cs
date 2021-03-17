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
    public partial class Loops : Form
    {
        private int selectedTask;
        private string expectedOutput;


        public Loops()
        {
            InitializeComponent();
            outputListView.View = View.List;
            whileLoopsPanel.Hide();
        }

        private void codeTextBox_Load(object sender, EventArgs e)
        {
            codeTextBox.Language = FastColoredTextBoxNS.Language.CSharp;
            codeTextBox.Text = "//No task selected";

            for (int i = 0; i < codeTextBox.LinesCount; i++)
            {
                if (!string.IsNullOrWhiteSpace(codeTextBox.GetLineText(i)))
                {
                    codeTextBox.GetLine(i).ReadOnly = true;
                }
            }
        }

        private void runButton_Click(object sender, EventArgs e)
        {
            var originalOutput = Console.Out;
            var newOutput = new StringWriter();

            Console.SetOut(newOutput);

            OleDbConnection connection = new OleDbConnection();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source = C:\Users\nabzi\Documents\CSTutor\CSTutor\ProjectDatabase.accdb;
Persist Security Info = False; ";

            CSharpCodeProvider codeProvider = new CSharpCodeProvider();
            CompilerParameters parameters = new CompilerParameters();

            parameters.ReferencedAssemblies.Add("System.dll");
            parameters.ReferencedAssemblies.Add("mscorlib.dll");
            parameters.GenerateExecutable = false;
            parameters.GenerateInMemory = true;


            outputListView.Items.Clear();

            CompilerResults results = codeProvider.CompileAssemblyFromSource(parameters, codeTextBox.Text);

            if(!results.Errors.HasErrors)
            {
                var compiledCode = results.CompiledAssembly.GetType("LoopsNS.LoopsClass");
                var codeMethod = compiledCode.GetMethod("LoopsMethod", BindingFlags.Static | BindingFlags.Public);
                codeMethod.Invoke(null, null);

                newOutput.Flush();

                outputListView.ForeColor = Color.LimeGreen;

                string consoleOutput = newOutput.GetStringBuilder().ToString();
                if (selectedTask == 1)
                {
                    connection.Open();

                    OleDbCommand command = new OleDbCommand("SELECT ExpectedOutput FROM Loops WHERE TaskID = 1", connection);
                    OleDbDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        expectedOutput = reader[0].ToString();
                    }

                    connection.Close();
                }
                else if (selectedTask == 2)
                {
                    if (!codeTextBox.Text.Contains("while"))
                    {
                        outputListView.Items.Add("Please use a while loop to complete this challenge");
                        
                    }
                    else
                    {
                        connection.Open();

                        OleDbCommand command = new OleDbCommand("SELECT ExpectedOutput FROM Loops WHERE TaskID = 2", connection);
                        OleDbDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            expectedOutput = reader[0].ToString();
                        }
                        connection.Close();

                        if (consoleOutput == expectedOutput)
                        {
                            outputListView.Items.Add("Success the code compiled correctly and the challenge was completed");
                            outputListView.Items.Add(" ");
                            outputListView.Items.Add("The console output was " + consoleOutput);
                        }
                        else
                        {
                            outputListView.Items.Add("The code compiled correctly but the output was not correct");
                            outputListView.Items.Add(" ");
                            outputListView.Items.Add("The expected output is " + expectedOutput);
                        }

                    }
                    

                    
                }

                
                


            }
            else
            {
                foreach(CompilerError error in results.Errors)
                {
                    Console.WriteLine(error);
                    newOutput.Flush();

                    outputListView.ForeColor = Color.Red;

                    outputListView.Items.Add(newOutput.GetStringBuilder().ToString());
                }
            }

        }


        private void resetButton_Click(object sender, EventArgs e)
        {
            codeTextBox.ReadOnly = false;
            codeTextBox.BackColor = Color.White;
            runButton.Enabled = true;

            if (selectedTask == 1)
            {
                OleDbConnection connection = new OleDbConnection();
                connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source = C:\Users\nabzi\Documents\CSTutor\CSTutor\ProjectDatabase.accdb;
Persist Security Info = False; ";

                connection.Open();

                OleDbCommand command = new OleDbCommand("SELECT ConsoleText FROM Loops WHERE TaskID = 1", connection);
                OleDbDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    codeTextBox.Text = reader[0].ToString();
                    codeTextBox.SelectAll();
                    codeTextBox.DoAutoIndent();
                }

                connection.Close();
            }
            else if(selectedTask == 2)
            {
                OleDbConnection connection = new OleDbConnection();
                connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source = C:\Users\nabzi\Documents\CSTutor\CSTutor\ProjectDatabase.accdb;
Persist Security Info = False; ";

                connection.Open();

                OleDbCommand command = new OleDbCommand("SELECT ConsoleText FROM Loops WHERE TaskID = 2", connection);
                OleDbDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    codeTextBox.Text = reader[0].ToString();
                    codeTextBox.SelectAll();
                    codeTextBox.DoAutoIndent();
                }

                connection.Close();
            }

            for (int i = 0; i < codeTextBox.LinesCount; i++)
            {
                if(!string.IsNullOrWhiteSpace(codeTextBox.GetLineText(i)))
                {
                    codeTextBox.GetLine(i).ReadOnly = true;
                }
            }

        }

        private void whileLoopsButton_Click(object sender, EventArgs e)
        {
            subtopicListPanel.Hide();
            whileLoopsPanel.Show();
        }

        private void loopsTask1Button_Click(object sender, EventArgs e)
        {
            selectedTask = 1;
            OleDbConnection connection = new OleDbConnection();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source = C:\Users\nabzi\Documents\CSTutor\CSTutor\ProjectDatabase.accdb;
Persist Security Info = False; ";
            connection.Open();

            OleDbCommand command = new OleDbCommand("SELECT TaskString FROM Loops WHERE TaskID = 1", connection);
            OleDbDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                taskLabel.Text = reader[0].ToString();
            }

            connection.Close();

            connection.Open();

            command = new OleDbCommand("SELECT ConsoleText FROM Loops WHERE TaskID = 1", connection);
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
                if (!string.IsNullOrWhiteSpace(codeTextBox.GetLineText(i)))
                {
                    codeTextBox.GetLine(i).ReadOnly = true;
                }
            }
        }

        private void loopsTask2Button_Click(object sender, EventArgs e)
        {
            selectedTask = 2;
            OleDbConnection connection = new OleDbConnection();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source = C:\Users\nabzi\Documents\CSTutor\CSTutor\ProjectDatabase.accdb;
Persist Security Info = False; ";
            connection.Open();

            OleDbCommand command = new OleDbCommand("SELECT TaskString FROM Loops WHERE TaskID = 2", connection);
            OleDbDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                taskLabel.Text = reader[0].ToString();
            }

            connection.Close();

            connection.Open();

            command = new OleDbCommand("SELECT ConsoleText FROM Loops WHERE TaskID = 2", connection);
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
                if (!string.IsNullOrWhiteSpace(codeTextBox.GetLineText(i)))
                {
                    codeTextBox.GetLine(i).ReadOnly = true;
                }
            }
        }
    }
}

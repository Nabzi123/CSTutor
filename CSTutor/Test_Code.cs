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
using System.IO;
using System.Reflection;
using Microsoft.CSharp;

namespace CSTutor
{
    public partial class Test_Code : Form
    {
        public Test_Code()
        {
            InitializeComponent();
            codeTextBox.Load += new EventHandler(codeTextBox_Load);
            runButton.Click += new EventHandler(runButton_Click);
        }

        private void codeTextBox_Load(Object sender, EventArgs e)
        {
            codeTextBox.Language = FastColoredTextBoxNS.Language.CSharp;

            codeTextBox.Text = @"using System;
namespace TestCodeNS
{
    public static class TestCode
    {
        public static void TestMethod()
        {
            //Use this to write whatever kind of code you want to   


        }
    }

}";

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

            var fileStream = new FileStream("Test.txt", FileMode.Create);
   
            

            string filename = fileStream.Name;

            var streamWriter = new StreamWriter(fileStream);



            var writerOutput = new StringWriter();

            Console.SetOut(streamWriter);

            CSharpCodeProvider provider = new CSharpCodeProvider();
            CompilerParameters parameters = new CompilerParameters();

            parameters.ReferencedAssemblies.Add("System.dll");
            parameters.ReferencedAssemblies.Add("mscorlib.dll");
            parameters.GenerateInMemory = true;
            parameters.GenerateExecutable = false;

            outputListView.Items.Clear();

            CompilerResults codeResults = provider.CompileAssemblyFromSource(parameters, codeTextBox.Text);

            if(!codeResults.Errors.HasErrors)
            {
                try
                {
                    var compiledCode = codeResults.CompiledAssembly.GetType("TestCodeNS.TestCode");
                    var compiledMethod = compiledCode.GetMethod("TestMethod", BindingFlags.Static | BindingFlags.Public);
                    compiledMethod.Invoke(null, null);

                    streamWriter.Flush();

                    streamWriter.Close();



                    string[] lines = File.ReadAllLines(fileStream.Name);

                    outputListView.ForeColor = Color.LimeGreen;

                    for (int i = 0; i < lines.Length; i++)
                    {
                        outputListView.Items.Add(lines[i]);
                    }
                }
                catch(Exception newException)
                {
                    Console.WriteLine(newException);

                    streamWriter.Flush();

                    streamWriter.Close();



                    string[] lines = File.ReadAllLines(fileStream.Name);

                    for (int i = 0; i < lines.Length; i++)
                    {
                        outputListView.Items.Add(lines[i]);
                    }
                    outputListView.Items.Add(writerOutput.GetStringBuilder().ToString());

                }
                

            }
            else
            {
                foreach (CompilerError error in codeResults.Errors)
                {
                    Console.WriteLine(error);

                    streamWriter.Flush();

                    streamWriter.Close();

                    outputListView.ForeColor = Color.Red;


                    string[] lines = File.ReadAllLines(fileStream.Name);

                    for (int i = 0; i < lines.Length; i++)
                    {
                        outputListView.Items.Add(lines[i]);
                    }
                    outputListView.Items.Add(writerOutput.GetStringBuilder().ToString());
                }
            }



        }

    }
}

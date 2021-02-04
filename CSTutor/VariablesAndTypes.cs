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
using System.Reflection;
using System.IO;
using Microsoft.CSharp;

namespace CSTutor
{
    public partial class VariablesAndTypes : Form
    {
        public VariablesAndTypes()
        {
            InitializeComponent();
        }

        private void codeTextBox_Load(object sender, EventArgs e)
        {
            codeTextBox.Language = FastColoredTextBoxNS.Language.CSharp;
            codeTextBox.Text = @"using System;
namespace VariablesAndTypesNS
{
    public static class VariablesAndTypesClass
    {
        public static void VariablesAndTypesMethod()
        {
            
        }
    }
}";

            for(int i = 0; i < codeTextBox.LinesCount; i++ )
            {
                if(!string.IsNullOrWhiteSpace(codeTextBox.GetLineText(i)))
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

            CSharpCodeProvider codeProvider = new CSharpCodeProvider();
            CompilerParameters parameters = new CompilerParameters();

            parameters.ReferencedAssemblies.Add("System.dll");
            parameters.ReferencedAssemblies.Add("mscorlib.dll");
            parameters.GenerateExecutable = false;
            parameters.GenerateInMemory = true;


            outputListView.Items.Clear();

            CompilerResults results = codeProvider.CompileAssemblyFromSource(parameters, codeTextBox.Text);

            if (!results.Errors.HasErrors)
            {
                var compiledCode = results.CompiledAssembly.GetType("VariablesAndTypesNS.VariablesAndTypesClass");
                var codeMethod = compiledCode.GetMethod("VariablesAndTypesMethod", BindingFlags.Static | BindingFlags.Public);
                codeMethod.Invoke(null, null);

                newOutput.Flush();

                outputListView.ForeColor = Color.LimeGreen;

                outputListView.Items.Add(newOutput.GetStringBuilder().ToString());
            }
            else
            {
                foreach (CompilerError error in results.Errors)
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
            runButton.Enabled = true;
            codeTextBox.BackColor = Color.White;
            codeTextBox.Text = @"using System;
namespace VariablesAndTypesNS
{
    public static class VariablesAndTypesClass
    {
        public static void VariablesAndTypesMethod()
        {
            
        }
    }
}";

        }
    }
}

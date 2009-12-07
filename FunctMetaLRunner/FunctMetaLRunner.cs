using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FunctMetaL.Core;
using System.IO;
using FunctMetaLRunner.Properties;
using System.Xml;

namespace FunctMetaLRunner
{
    public partial class FunctMetaLRunner : Form
    {
        string filePath = string.Empty;
        public FunctMetaLRunner()
        {
            InitializeComponent();
            txtXml.AppendText("<?xml version=\"1.0\"?>\r\n");
            txtXml.AppendText("<TestSuite>\r\n");
            txtXml.AppendText("  <Test name=\"Test\">\r\n");
            txtXml.AppendText("  </Test>\r\n");
            txtXml.AppendText("</TestSuite>\r\n");
            Main.Log = true;
        }

        private void tsButExecute_Click(object sender, EventArgs e)
        {
            
            Main main = new Main();
            FunctMetaL.Util.Logger.Clear();
            txtResult.Clear();
            
            try
            {
                if (filePath == string.Empty)
                    filePath = Path.GetTempFileName();

                using (StreamWriter sw = new StreamWriter(filePath))
                {
                    sw.Write(txtXml.Text);
                }

                main.TestSuite = filePath;
                main.Start();
                tabControl1.TabPages["tabResult"].Show();
                txtResult.Text = FunctMetaL.Util.Logger.Log.ToString();
            }
            catch (Exception ex)
            {
                txtResult.Text = ex.Message;
            }
           
        }

        private void variableToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            txtXml.Text = FormatText(txtXml.Text.Insert(txtXml.SelectionStart, Settings.Default.Variable)); 
        }

        private void arrayToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            txtXml.Text = FormatText(txtXml.Text.Insert(txtXml.SelectionStart, Settings.Default.Array));            
        }

        private void messageToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            txtXml.Text = FormatText(txtXml.Text.Insert(txtXml.SelectionStart, Settings.Default.Message)); 
        }

        private void forLoopToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            txtXml.Text = FormatText(txtXml.Text.Insert(txtXml.SelectionStart, Settings.Default.For)); 
        }

        private void whileLoopToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            txtXml.Text = FormatText(txtXml.Text.Insert(txtXml.SelectionStart, Settings.Default.While)); 
        }

        private void doWhileLoopToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            txtXml.Text = FormatText(txtXml.Text.Insert(txtXml.SelectionStart, Settings.Default.DoWhile)); 
        }

        private void switchToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            txtXml.Text = FormatText(txtXml.Text.Insert(txtXml.SelectionStart, Settings.Default.Switch)); 
        }

        private void ifElseToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            txtXml.Text = FormatText(txtXml.Text.Insert(txtXml.SelectionStart, Settings.Default.IfElse)); 
        }

        private void breakToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string @break = Settings.Default.Break;
            txtXml.Text = FormatText(txtXml.Text.Insert(txtXml.SelectionStart, Settings.Default.Break)); 
        }

        private void evalToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            txtXml.Text = FormatText(txtXml.Text.Insert(txtXml.SelectionStart, Settings.Default.Eval)); 
        }

        private void commentToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            txtXml.Text = FormatText(txtXml.Text.Insert(txtXml.SelectionStart, Settings.Default.Comment)); 
        }

        private void importToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtXml.Text = FormatText(txtXml.Text.Insert(txtXml.SelectionStart, Settings.Default.Import)); 
        }

        private void pluginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtXml.Text = FormatText(txtXml.Text.Insert(txtXml.SelectionStart, Settings.Default.Plugin)); 
        }

        private void processToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtXml.Text = FormatText(txtXml.Text.Insert(txtXml.SelectionStart, Settings.Default.Process)); 
        }

        static string FormatText(string text)
        {

            XmlTextWriter writer = null;
            XmlDocument doc = new XmlDocument();
            XmlWriterSettings xwSettings = new XmlWriterSettings();
            string formattedText = string.Empty;
            try
            {
                doc.LoadXml(text);

                writer = new XmlTextWriter(".data.xml", null);
                writer.Formatting = Formatting.Indented;
                doc.Save(writer);
                writer.Close();

                using (StreamReader sr = new StreamReader(".data.xml"))
                {
                    formattedText = sr.ReadToEnd();
                }
            }
            finally
            {
                File.Delete(".data.xml");
            }
            return formattedText;
        }
    }
}

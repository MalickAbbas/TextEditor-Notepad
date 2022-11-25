using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotePad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void newToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
            richTextBox1.Clear();
        }

        private void openToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialogbox = new OpenFileDialog();
            dialogbox.Title = "Open";
            dialogbox.Filter = "Text Document(*.txt)|*.txt| All Files (*.*)|*.* ";
            if(dialogbox.ShowDialog()== DialogResult.OK)
            {
                richTextBox1.LoadFile(dialogbox.FileName, RichTextBoxStreamType.PlainText);
                this.Text = dialogbox.FileName;
            }
        }

        private void saveToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialogbox = new SaveFileDialog();
            dialogbox.Title = "Save";
            dialogbox.Filter = "Text Document(*.txt)|*.txt| All Files (*.*)|*.* ";
            if (dialogbox.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SaveFile(dialogbox.FileName, RichTextBoxStreamType.PlainText);
                this.Text = dialogbox.FileName;
            }
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void undoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void redoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();
        }

        private void copyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void cutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void pasteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void selectAllToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        private void fontsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog test = new FontDialog();
            if (test.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Font = test.Font;
            }
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog test = new ColorDialog();
            if (test.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.ForeColor = test.Color;
            }
        }
    }
}

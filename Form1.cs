using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WordProcessorProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                rcDisplay.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.Filter = "Text Files (*.txt)*|.txt|All files(*.*)|*.*";

                if (openFileDialog1.ShowDialog() ==DialogResult.OK )

                { rcDisplay.LoadFile(openFileDialog1.FileName,RichTextBoxStreamType.PlainText); }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            newToolStripMenuItem_Click(sender, e);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            openToolStripMenuItem_Click(sender, e);
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

                saveFileDialog1.Filter = "txt Files (*.txt)*|.txt|All files(*.*)|*.*";

                if (saveFileDialog1.ShowDialog() == DialogResult.OK)

                {System.IO.File.WriteAllText(saveFileDialog1.FileName,rcDisplay.Text); }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            saveToolStripMenuItem_Click(sender, e); 
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                printPreviewDialog1.Document = printDocument1;
                printPreviewDialog1.ShowDialog();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            printToolStripMenuItem_Click(sender, e);
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            try
            {
                e.Graphics.DrawString(rcDisplay.Text, new Font("Arial", 18, FontStyle.Regular), Brushes.Black, 120, 120);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult meExit;
                meExit = MessageBox.Show("Confirm if you want to exit", "Word App", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if(meExit == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void undoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                rcDisplay.Undo();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            undoToolStripMenuItem1_Click(sender, e);
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                rcDisplay.Redo();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            redoToolStripMenuItem_Click(sender, e);
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                rcDisplay.Copy();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                rcDisplay.Cut();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                rcDisplay.Paste();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void colourToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if(colorDialog1.ShowDialog() == DialogResult.OK)
                {
                    rcDisplay.ForeColor = colorDialog1.Color;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (fontDialog1.ShowDialog() == DialogResult.OK)
                {
                    rcDisplay.Font =fontDialog1.Font;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

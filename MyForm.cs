using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
//using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Aont
{
    public partial class MyForm : Form
    {


        public MyForm()
        {
            InitializeComponent();

            MyButton.Initialize(this.panel1, 4,4);

        }

        private void startSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MyButton.ReStart();
        }


        private void showClickCheckCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MyButton.ClickedCheck
                = this.showClickCheckCToolStripMenuItem.Checked
                = !this.showClickCheckCToolStripMenuItem.Checked;
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void versionVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aont");
        }


        private void changeSizeSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SizeDialogue sd = new SizeDialogue();

            if (sd.ShowDialog() == DialogResult.OK)
            {
                MyButton.ReStart(sd.row,sd.column);
            }
        }
    }
}
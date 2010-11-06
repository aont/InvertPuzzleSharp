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

            MyButton.Initialize(this.panel1, 4);

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



        private void toolStripComboBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int num = 0;
                try
                {
                    num = int.Parse(toolStripComboBox1.Text);
                }
                catch
                {
                    MessageBox.Show("Not A Number!");
                    return;
                }
                if (num > 2)
                {
                    MyButton.ReStart(num);

                }
                else
                {
                    MessageBox.Show("Input a number larger than or equal to 3");
                }
            }



        }
    }
}
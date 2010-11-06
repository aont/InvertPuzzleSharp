using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
//using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Imaging;

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




        private void changeSizeSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SizeDialogue sd = new SizeDialogue();

            if (sd.ShowDialog() == DialogResult.OK)
            {
                MyButton.ReStart(sd.row,sd.column);
            }
        }

        private void loadLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                MyButton.Load(new Bitmap(openFileDialog1.FileName));
            }
        }

        private void saveCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Bitmap bmp = MyButton.Save();
                bmp.Save(saveFileDialog1.FileName,ImageFormat.Png);
            }
        }

        private void openFileDialog1_HelpRequest(object sender, EventArgs e)
        {
            MessageBox.Show("Select a Image file that specifies the states of the check-boxes.");
        }

        private void saveFileDialog1_HelpRequest(object sender, EventArgs e)
        {
            MessageBox.Show("Where to save the PNG Save Data.");
        }

    }
}
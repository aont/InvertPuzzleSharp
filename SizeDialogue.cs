using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Aont
{
    public partial class SizeDialogue : Form
    {
   
        public int row, column;
        public SizeDialogue()
        {
            InitializeComponent();
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                row = int.Parse(comboBox1.Text);
                if (row < 1)
                    throw new Exception();
            }
            catch
            {
                MessageBox.Show("Row must be a Natural Number.", "FormatException!");
                comboBox1.Text = "3";
            }

            if (checkBox1.Checked)
                comboBox2.Text = comboBox1.Text;
        }

        private void comboBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                column = int.Parse(comboBox2.Text);
                if (column < 1)
                    throw new Exception();
            }
            catch
            {
                MessageBox.Show("Column must be A Natural Number.", "FormatException!");
                comboBox2.Text = "3";
            }

            if (checkBox1.Checked)
                comboBox1.Text = comboBox2.Text;
        }


        

    }
}

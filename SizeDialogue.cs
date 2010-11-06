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
            comboBox1.Text = (row = MyButton.Row).ToString();
            comboBox2.Text = (column = MyButton.Column).ToString();
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                row = int.Parse(comboBox1.Text);
                if (row < 1)
                    throw new Exception();
                if (checkBox1.Checked)
                    column = row;
            }
            catch
            {
                MessageBox.Show("Row must be a Natural Number.", "FormatException!");
                comboBox1.Text = (row = MyButton.Row).ToString();
                if (checkBox1.Checked)
                    column = row;
            }

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
                comboBox2.Text = (column = MyButton.Column).ToString();
            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                label2.Text = "Size";
                label3.Visible = false;
                comboBox2.Visible = false;
            }
            else
            {
                label2.Text = "Row";
                label3.Visible = true;
                comboBox2.Visible = true;
            }
        }




    }
}

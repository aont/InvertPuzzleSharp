using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace Aont
{
    public class MyButton : CheckBox
    {
        const string NULL = null;
        static string CheckText = "✓";
        static bool ImComplete = true;
        public static bool ClickedCheck
        {
            get { return _ClickedCheck; }
            set
            {
                if (_ClickedCheck = value)
                {
                    for (int i = 0; i < row; i++)
                    {
                        for (int j = 0; j < column; j++)
                        {
                            var button = Buttons[i, j];
                            if (button.Clicked)
                                button.Text = CheckText;
                            else
                                button.Text = NULL;
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < row; i++)
                    {
                        for (int j = 0; j < column; j++)
                        {
                            Buttons[i, j].Text = NULL;
                        }
                    }
                }

            }
        }
        private static bool _ClickedCheck = false;
        static MyButton[,] Buttons;
      public  static int row, column;
        static Control ParentControl;
        bool Clicked = false;

        public readonly int i, j;
        public MyButton(int i, int j)
        {
            this.i = i;
            this.j = j;
            this.Width = this.Height = 32;
            this.Top = 32 * i;
            this.Left = 32 * j;
            this.Text = NULL;
            this.Appearance = Appearance.Button;
            this.Margin = new Padding(0);
            this.TextAlign = ContentAlignment.MiddleCenter;

        }
        protected override void OnClick(EventArgs e)
        {
            if (i > 0)
            {
                Buttons[i - 1, j].Invert();
            }
            if (i < row - 1)
            {
                Buttons[i + 1, j].Invert();
            }
            if (j > 0)
            {
                Buttons[i, j - 1].Invert();
            }
            if (j < column - 1)
            {
                Buttons[i, j + 1].Invert();
            }
            this.Invert();
            if ((this.Clicked = !this.Clicked) & ClickedCheck)
            { this.Text = CheckText; }
            else { this.Text = NULL; }

            if (ImComplete)
                if (CompleteCheck() == true)
                    MessageBox.Show("Completed!", "Congraturations");

        }
        bool CompleteCheck()
        {
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    if (!Buttons[i, j].Checked)
                        return false;
                }
            }
            return true;
        }
        void Invert()
        {
            this.Checked = !this.Checked;
        }

        public static void Initialize(Control parentControl, int row, int column)
        {
            ImComplete = true;
            ParentControl = parentControl;
            MyButton.row = row;
            MyButton.column = column;
            Buttons = new MyButton[row, column];
            parentControl.SuspendLayout();
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    var button = Buttons[i, j] = new MyButton(i, j);

                    parentControl.Controls.Add(button);
                }
            }
            parentControl.Size = new Size(column * 32, row * 32);
            parentControl.ResumeLayout(false);
        }
        public static void ReStart(int row, int column)
        {
            ParentControl.SuspendLayout();
            ParentControl.Controls.Clear();
            Initialize(ParentControl, row, column);
        }
        public static void ReStart()
        {
            ImComplete = true;
            ParentControl.SuspendLayout();
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    var button = Buttons[i, j];
                    button.Clicked = false;
                    button.Checked = false;
                    button.Text = NULL;
                }
            }
            ParentControl.ResumeLayout(false);
        }


    }
}

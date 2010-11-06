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
        static string CheckText = "レ";
        public static bool ClickedCheck
        {
            get { return _ClickedCheck; }
            set
            {
                if (_ClickedCheck = value)
                {
                    for (int i = 0; i < size; i++)
                    {
                        for (int j = 0; j < size; j++)
                        {
                            var button = Buttons[i, j];
                            if (button.Clicked)
                                button.Text = CheckText;
                            else
                                button.Text = "";
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < size; i++)
                    {
                        for (int j = 0; j < size; j++)
                        {
                            Buttons[i, j].Text = "";
                        }
                    }
                }

            }
        }
        private static bool _ClickedCheck = false;
        static MyButton[,] Buttons;
        static int size;
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
            this.Text = "";
            this.Appearance = Appearance.Button;
            this.Margin = new Padding(0);  

        }
        protected override void OnClick(EventArgs e)
        {
            if (i > 0)
            {
                Buttons[i - 1, j].Invert();
            }
            if (i < size - 1)
            {
                Buttons[i + 1, j].Invert();
            }
            if (j > 0)
            {
                Buttons[i, j - 1].Invert();
            }
            if (j < size - 1)
            {
                Buttons[i, j + 1].Invert();
            }
            this.Invert();
            if ((this.Clicked = !this.Clicked) & ClickedCheck)
            { this.Text = CheckText; }
            else { this.Text = ""; }

        }

        void Invert()
        {
            this.Checked = !this.Checked;
        }
        public static void Initialize(Control parentControl, int size)
        {
            ParentControl = parentControl;
            MyButton.size = size;
            Buttons = new MyButton[size, size];
            parentControl.SuspendLayout();
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    var button = Buttons[i, j] = new MyButton(i, j);

                    parentControl.Controls.Add(button);
                }
            }
            parentControl.Size = new Size(size * 32, size * 32);
            parentControl.ResumeLayout(false);
        }

        public static void ReStart(int size)
        {
            ParentControl.SuspendLayout();
            ParentControl.Controls.Clear();
            Initialize(ParentControl, size);
        }
        public static void ReStart()
        {
            ParentControl.SuspendLayout();
            ParentControl.Controls.Clear();
            Initialize(ParentControl, size);
        }


    }
}

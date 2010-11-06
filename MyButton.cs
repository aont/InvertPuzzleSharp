using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Imaging;

namespace Aont
{
    public class MyButton : CheckBox
    {
        const string NULL = null;
        static string CheckText = "✓";
        static bool ImComplete = true;
        public static void Load(Bitmap bmp)
        {
            ImComplete = true;
            ReStart(bmp.Height, bmp.Width);

            ParentControl.SuspendLayout();


            for (int i = 0; i < Row; i++)
            {
                for (int j = 0; j < Column; j++)
                {
                    var button = Buttons[i, j];
                    if (button.Clicked == (bmp.GetPixel(j, i).GetBrightness() > 0.5f))
                        button.OnClick(null);

                }
            }

            ParentControl.ResumeLayout(false);

        }
        public static Bitmap Save()
        {
            Bitmap bmp = new Bitmap(Column, Row);

            for (int i = 0; i < Row; i++)
            {
                for (int j = 0; j < Column; j++)
                {
                    var button = Buttons[i, j];
                    if (!button.Clicked)
                        bmp.SetPixel(j, i, Color.White);
                }
            }

            return bmp;

        }
        public static bool ClickedCheck
        {
            get { return _ClickedCheck; }
            set
            {
                if (_ClickedCheck = value)
                {
                    for (int i = 0; i < Row; i++)
                    {
                        for (int j = 0; j < Column; j++)
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
                    for (int i = 0; i < Row; i++)
                    {
                        for (int j = 0; j < Column; j++)
                        {
                            Buttons[i, j].Text = NULL;
                        }
                    }
                }

            }
        }
        private static bool _ClickedCheck = false;
        static MyButton[,] Buttons;
        public static int Row, Column;
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
            //this.TabStop = false;
        }
        protected override bool IsInputKey(Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Down:
                case Keys.Right:
                case Keys.Up:
                case Keys.Left:
                    break;
                default:
                    return base.IsInputKey(keyData);
                    //break;
            }
            return true;
        }
        protected override void OnKeyDown(KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up:
                    if (i > 0)
                        Buttons[i - 1, j].Focus();
                    break;
                case Keys.Down:
                    if (i < Row - 1)
                        Buttons[i + 1, j].Focus();
                    break;
                case Keys.Left:
                    if (j > 0)
                        Buttons[i, j-1].Focus();
                    break;
                case Keys.Right:
                    if (j < Column-1)
                        Buttons[i,j +1].Focus();
                    break;
                default:
                    break;
            }

            base.OnKeyDown(e);
        }
        protected override void OnClick(EventArgs e)
        {

            if (i > 0)
            {
                Buttons[i - 1, j].Invert();
            }
            if (i < Row - 1)
            {
                Buttons[i + 1, j].Invert();
            }
            if (j > 0)
            {
                Buttons[i, j - 1].Invert();
            }
            if (j < Column - 1)
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
            for (int i = 0; i < Row; i++)
            {
                for (int j = 0; j < Column; j++)
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
            ReStart(row, column);
        }
        public static void Initialize(Control parentControl, string image)
        {
            ImComplete = true;
            ParentControl = parentControl;
            Load(new Bitmap(image));
        }
        public static void ReStart(int row, int column)
        {
            ImComplete = true;
            ParentControl.SuspendLayout();
            ParentControl.Controls.Clear();
            MyButton.Row = row;
            MyButton.Column = column;
            Buttons = new MyButton[row, column];
            ParentControl.SuspendLayout();
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    var button = Buttons[i, j] = new MyButton(i, j);

                    ParentControl.Controls.Add(button);
                }
            }
            ParentControl.Size = new Size(column * 32, row * 32);
            ParentControl.ResumeLayout(false);
        }
        public static void ReStart()
        {
            ImComplete = true;
            ParentControl.SuspendLayout();
            for (int i = 0; i < Row; i++)
            {
                for (int j = 0; j < Column; j++)
                {
                    var button = Buttons[i, j];
                    button.Clicked = false;
                    button.Checked = false;
                    button.Text = NULL;
                }
            }
            ParentControl.ResumeLayout(false);
        }

        /*
        protected override void OnMouseEnter(EventArgs eventargs)
        {
            base.OnMouseEnter(eventargs);
            this.Focus();
        }
        */


    }
}

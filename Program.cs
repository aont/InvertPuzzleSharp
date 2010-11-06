using System;
using System.Collections.Generic;
//using System.Linq;
using System.Windows.Forms;

namespace Aont
{
    static class Program
    {
        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MyForm(args));
        }
    }
}

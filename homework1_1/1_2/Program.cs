using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1_2
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Form1 f = new Form1();
            f.Text = "乘法计算器";
            f.init();
            Application.Run(f);
        }
    }
}

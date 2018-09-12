using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1_2
{
    public partial class Form1 : Form
    {
        TextBox txt1 = new TextBox();
        TextBox txt2 = new TextBox();
        Button btn = new Button();
        Label lbl = new Label();

        public void init()
        {
            this.Controls.Add(txt1);
            this.Controls.Add(txt2);
            this.Controls.Add(btn);
            this.Controls.Add(lbl);

            txt1.Dock = System.Windows.Forms.DockStyle.Top;
            txt2.Dock = System.Windows.Forms.DockStyle.Right;
            btn.Dock = System.Windows.Forms.DockStyle.Fill;
            lbl.Dock = System.Windows.Forms.DockStyle.Bottom;

            btn.Text = "求乘积";
            lbl.Text = "用于显示结果的标签";
            this.Size = new Size(400, 120);

            btn.Click += new System.EventHandler(this.button1_Click);

        }

        public void button1_Click(object sender, EventArgs e)
        {
            string s1 = txt1.Text;
            string s2 = txt2.Text;
            double a = Double.Parse(s1);
            double b = Double.Parse(s2);

            lbl.Text = a + " × " + b + " = " + a * b;
        }

    }
}

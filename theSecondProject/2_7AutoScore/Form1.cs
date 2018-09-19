using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2_7AutoScore
{
    public partial class autoScore : Form
    {
        int a, b;
        string op;
        int result;

        public autoScore()
        {
            InitializeComponent();
        }


        private void btnNew_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            a = rnd.Next(9) + 1;
            b = rnd.Next(9) + 1;
            int c = rnd.Next(4);

            switch(c)
            {
                case 0 : op = "+"; result = a + b;break;
                case 1 : op = "-"; result = a - b;break;
                case 2 : op = "*"; result = a * b;break;
                case 3 : op = "/"; result = a / b;break;
            }

            labelA.Text = (" " + a);
            labelOp.Text = (" " + op);
            labelE.Text = (" " + "=");
            labelB.Text = (" " + b);
            textAnswer.Text = ("");
        }

        private void btnJudge_Click(object sender, EventArgs e)
        {
            string str = textAnswer.Text;
            double d = Double.Parse(str);
            string disp = a + op + b + "=" + str ;
            if(result==d)
            {
                disp += "√";
            }
            else
            {
                disp += "×";
            }
            listDisp.Items.Add(disp);
        }
    }
}

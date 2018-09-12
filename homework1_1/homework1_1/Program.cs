using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "";
            double a, b;
            Console.WriteLine("请输入两个数字");
            s = Console.ReadLine();
            a = Double.Parse(s);

            s = Console.ReadLine();
            b = Double.Parse(s);

            Console.WriteLine("这两个数的乘积为：" + a * b);
        }
    }
}

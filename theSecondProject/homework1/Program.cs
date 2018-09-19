using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//分解质因数
namespace homework1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入一个数字");
            string str;
            str = Console.ReadLine();
            int a;
            a = int.Parse(str);
            int b = a;
            string c = "这个数的质因子为: " ;
            int i = 2;
            while (b!=1)
            {
                if(b%i == 0)
                {
                    b = b / i;
                    if (b % i != 0)
                    {
                        c = c + i;
                        c = c + " ";
                    }
                }
                else
                {
                    i++;
                }
            }
            Console.WriteLine(c);

        }
    }
}

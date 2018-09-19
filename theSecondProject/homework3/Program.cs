using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//埃氏筛法
namespace homework3
{
    class Program
    {
        static void Main(string[] args)
        {
             for(int i =1;i<100;i++)
            {
                bool a = true;
                for(int j = 2;j<i;j++)
                {
                    if(i%j==0)
                    {
                        a = false;
                        break;
                    }
                }
                if(a)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}

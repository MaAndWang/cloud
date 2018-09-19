using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//求数组元素的最大值，最小值，平均值
namespace homework2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] number = new int[10] { 63, 22, 43, 767, 34, 23, 5, 97, 90, 345 };
            int Max = number[0], Min = number[0], Sum = 0;
            double average = 0.0 ;
            for(int i = 0;i<10;i++)
            {
                if (Max < number[i])
                {
                    Max = number[i];
                }
                if(Min>number[i])
                {
                    Min = number[i];
                }
                Sum += number[i];
            }
            average = Sum / 10.0;
            Console.WriteLine("这个数组中元素的最大值为： " + Max + " 最小值为： " + Min + " 平均数为: " + average + " 所有元素和为： " + Sum);
        }
    }
}

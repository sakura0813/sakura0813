using System.Diagnostics.CodeAnalysis;

namespace C_sharp_foundation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 不使用第三个变量，交换两个变量
            //int num1 = 12;
            //int num2 = 13;

            //Console.WriteLine("交换前的变量num1={0},num2={1}", num1, num2);

            //num1 = num2 + num1;
            //num2 = num1 - num2;
            //num1 = num1 - num2;

            //Console.WriteLine("交换后的变量num1={0}，num2={1}",num1,num2);
            //Console.ReadKey();
            #endregion

            #region 使用方法交换两个变量
            //int change_num1 = 23;
            //int change_num2 = 24;

            //Console.WriteLine("交换前的变量change_num1={0},change_num2={1}", change_num1, change_num2);

            //调用方法

            //Change_num(ref change_num1,ref change_num2);

            //Console.WriteLine("交换前的变量change_num1={0},change_num2={1}", change_num1, change_num2);
            //Console.WriteLine();
            #endregion

            #region  计算字符串的个数并输出
            //Console.WriteLine("请输入一个字符串：");
            //string str=Console.ReadLine();

            //Console.WriteLine("字符串的长度为：{0}",str.Length);

            #endregion

            #region  用方法计算输入的两个数字的最大数值

            //Console.WriteLine("请输入两个数字：");
            //int num1 = Convert.ToInt32(Console.ReadLine());
            //int num2 = Convert.ToInt32(Console.ReadLine());

            //int max_num = Get_Max_num(num1,num2);

            //Console.WriteLine("两个数的最大值为：{0}",max_num);

            #endregion

            #region  用方法计算多个数字的最大值

            //int max_num = Change_num1(12,21,32,43,54,65,444);

            //Console.WriteLine("这些数字的最大数是：{0}",max_num);
            #endregion

            #region  1-100的数字和
            //int sum = 0;
            //for (int i = 0; i <= 100; i++) 
            //{
            //    sum = sum + i;
            //}

            //Console.WriteLine("1-100的和为：{0}",sum);

            #endregion

            #region  1-100所有奇数的和
            //int sum = 0;
            //for (int i = 0; i < 100; i++)
            //{
            //    if (!(i % 2 ==0)) 
            //    {
            //        sum = sum + i;
            //    }
            //}

            //Console.WriteLine("1-100所有奇数的和:{0}",sum);

            #endregion
        }

        private static int Change_num1(params int[] pms)
        {
            int max = pms[0];
            for (int i = 1; i < pms.Length; i++)
            {
                if (max < pms[i])
                {
                    max = pms[i];
                }
            }
            return max;
        }

        //计算两个数字的最大值方法
        private static int Get_Max_num(int num1, int num2)
        {
            int max = num1;
            if (num2 > max) 
            { 
                max= num2;
            }
            return max;
        }

        //交换变量的方法
        private static void Change_num(ref int change_num1,ref int change_num2)
        {
            int temp=change_num1;
            change_num1 = change_num2;
            change_num2 = temp;
        }
    }
}
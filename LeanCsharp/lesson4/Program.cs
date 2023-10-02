namespace lesson4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //#region 异常捕获
            //int Age = 0;
            ////异常捕获
            //try
            //{
            //    //正常输入数字可以，但是出现字母字符就会出错
            //    Age = Convert.ToInt32(Console.ReadLine());
            //}
            //catch (Exception)
            //{
            //    //程序出现异常，会执行这里面的语句
            //    Console.WriteLine("您输入的年龄有误\n已将年龄设置为默认值");
            //}
            //Console.WriteLine("你的年龄是：{0}", Age);
            //#endregion

            //#region 水仙花数
            ////遍历100到999
            //for (int i = 100; i <= 999; i++)
            //{
            //    //求出当前i的百位，十位，个位
            //    int baiwei = i / 100;
            //    int shiwei = (i / 10) - baiwei * 10;
            //    int gewei = i - baiwei * 100 - shiwei * 10;
            //    //求出百位，十位，个位的三次方
            //    int num1 = (int)Math.Pow(baiwei, 3);
            //    int num2 = (int)Math.Pow(shiwei, 3);
            //    int num3 = (int)Math.Pow(gewei, 3);
            //    //if判断
            //    if (i==num1+num2+num3)
            //    {
            //        Console.WriteLine("水仙花数为：{0}",i);
            //    }

            //}
            //#endregion

            #region 乘法表
            for (int i = 1; i < 10; i++) 
            {
                for (int j = 1; j <= 9; j++)
                {
                    Console.Write("{0}*{1}={2}\t",i,j,i*j);
                }
                Console.WriteLine();
            }
            #endregion
        }
    }
}
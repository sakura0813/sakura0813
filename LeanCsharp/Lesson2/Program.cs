namespace Lesson2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 1;
            double num1 = 2.0;

            //单引号引起来
            char a= 'a';

            //双引号引起来
            string b= "ABCDEFG";

            //decimal类型用来存储精度相对来说要求比较高的值，且变量后面要加“m”
            decimal money = 3000m;


            Console.WriteLine("{0},{1},{2},{3},{4}",num,num1, a, b, money);
        }
    }
}
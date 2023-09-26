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


            //隐式类型转换,有小的转换为大的，隐式转换
            int changetoDouble = 5;
            double change = changetoDouble;
            Console.WriteLine(change.GetType());

            //显示转换,由小的数据转换为大的数据，强制转换
            double changetoInt = 303.3;
            double changetoInt1 = 303.5;
            int res = (int)changetoInt;
            int res1 = (int)changetoInt1;
            Console.WriteLine(res);
            Console.WriteLine(res.GetType());
            Console.WriteLine(res1);
            Console.WriteLine(res1.GetType());

            //两个int变量的数据进行运算，虽然拿一个double类型接受，但是依然是整数
            int n1 = 5;
            int n2 = 2;
            double n3 = n1 / n2;
            Console.WriteLine(n3);

            //通过数字乘以1.0可以改变数据类型，结果为2.5
            int n4 = 5;
            int n5 = 3;
            double n6 = n1*1.0 / n2;
            Console.WriteLine(n6);

            //改变一个数据的数据类型，并不能改变接收数据，结果依然是2
            double n7 = 5;
            int n8 = 3;
            double n9 = n1 / n2;
            Console.WriteLine(n9);

            int a1 = 10;
            int b1 = 3;
            double c = a1*1.0 / b1;
            //可以通过这个小语法改变保留的小数位数；
            Console.WriteLine("{0:0.00}",c);


        }
    }
}
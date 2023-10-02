namespace lesson3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //比较三个输入数字的大小
            Console.WriteLine("请输入第一个数字：");
            int num1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("请输入第二个数字：");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("请输入第三个数字：");
            int num3 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    Console.WriteLine("三个数字中最大的是第一个数：{0}",num1);
                }
                else 
                {
                    Console.WriteLine("三个数字中最大的是第三个数：{0}", num3);
                }
            }
            //这种情况是：num1<num2
            else if (num3 > num2)
            {
                Console.WriteLine("最大的数字是第三个数字：{0}",num3);
            }
            else 
            {
                Console.WriteLine("最大的数字是第二个数字：{0}", num2);
            }
        }
    }
}
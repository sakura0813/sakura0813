namespace lesson6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 定义数组
            //定义数组，后面是数组的元素
            int[] nums = { 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, };

            //定义数组，限制数组的长度
            int[] nums2 = new int[10];
            //以上两种都可以声明数组，含义不一样

            for (int i = 0; i < nums2.Length; i++)
            {
                //将nums的值赋值给nums2
                nums2[i] = nums[i];
            }

            for (int i = 0; i < nums2.Length; i++)
            {
                //输出nums2
                Console.WriteLine(nums2[i]);
            }
            #endregion

            #region 数组联系题
            int[] numbers = { 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, };

            //如果要比较数组中的最大值和最小值，一定要让数组中的某个数等于max和min，不然会有bug
            int max = numbers[0];
            int min = numbers[0];
            int count = 0;

            for (int i = 0; i < numbers.Length; i++)
            {

                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
                if (numbers[i] < min)
                {
                    min = numbers[i];
                }

                count = count + numbers[i];

            }

            Console.WriteLine("这组数组的最大值为：{0}，最小值为：{1}，总和为：{2},平均值为：{3}", max, min, count, count / numbers.Length);
            #endregion 
        }
    }
}
namespace lesson5
{

    //声明一个枚举类型，枚举是为了规范代码书写，多人员开发时规范变量。
    //声明时在命名空间里声明
    public enum QQstatus
    {
        Online,
        Offline,
        Leave,
        Hide,
        Qme
    }

    public struct Person 
    { 
        //结构的内部是字段，必须用public修饰，不然外部访问不到
        public string Name;
        public int Id;
        public string Title;
        public string Description;
    }


    internal class Program
    {
        static void Main(string[] args)
        {

            #region 枚举 将枚举类型装换为int，将int装换为枚举类型
            //创建一个枚举变量并赋值
            QQstatus status = QQstatus.Online;

            //枚举类型可以强转换为int类型，转换的值就是么，枚举成员在枚举里出现的次序
            int a = (int)status;
            int b = (int)QQstatus.Offline;
            int c = (int)QQstatus.Qme;
            int d = (int)QQstatus.Hide;

            Console.WriteLine("{0}\n{1}\n{2}\n{3}", a, b, c, d);

            //当然也可以逆向输出枚举成员,默认从零开始
            int test = 3;
            QQstatus qqstatus = (QQstatus)test;

            Console.WriteLine(qqstatus);
            #endregion

            #region  枚举类型练习
            Console.WriteLine("请输入您的状态：0--Online，1--Offline，2--Leave，3--Hide，4--Hide");

            string F_status = Console.ReadLine();
            switch (F_status)
            {
                case "0":
                    //将输入的字符串转成枚举类型
                    QQstatus s1 = (QQstatus)Enum.Parse(typeof(QQstatus), F_status);
                    Console.WriteLine("你选择的状态为{0}",s1);
                    break;
                case "1":
                    QQstatus s2 = (QQstatus)Enum.Parse(typeof(QQstatus), F_status);
                    Console.WriteLine("你选择的状态为{0}", s2);
                    break;
                case "2":
                    QQstatus s3 = (QQstatus)Enum.Parse(typeof(QQstatus), F_status);
                    Console.WriteLine("你选择的状态为{0}", s3);
                    break;
                case "3":
                    QQstatus s4 = (QQstatus)Enum.Parse(typeof(QQstatus), F_status);
                    Console.WriteLine("你选择的状态为{0}", s4);
                    break;
                case "4":
                    QQstatus s5 = (QQstatus)Enum.Parse(typeof(QQstatus), F_status);
                    Console.WriteLine("你选择的状态为{0}", s5);
                    break;
            }


            #endregion

            #region 结构
            Person person = new Person();
            person.Name = "Test1";
            person.Title = "Test1";
            person.Description = "Test1";
            
            Person person2 = new Person();
            person2.Title = "Test2";
            person2.Description = "Test2";

            //结构和字段相似，变量可以盛放一个值，但是结构中一个字段可以盛放多个值，这是和变量不同的地方
            Console.WriteLine("person的名字为{0},person2的名字为{1}",person.Name,person2.Name);
            #endregion
        }
    }
}
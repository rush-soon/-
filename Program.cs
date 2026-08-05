using System.ComponentModel.Design;
using System.Linq.Expressions;
using System.Runtime.InteropServices;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            //Console.WriteLine("请输入数字:");
            //Console.WriteLine("请输入数字:");
            //string num1 = Console.ReadLine();
            //string num2 = Console.ReadLine();
            //int n1 = int .Parse(num1);
            //int n2 = int .Parse(num2);
            //int n3 = n1 + n2;
            //Console.WriteLine(n3);

            //Console.WriteLine("请输入温度：");
            //string h = Console.ReadLine();
            //double d = double.Parse(h);
            //double s = (d - 32) * 5 / 9;
            //s = Math.Round(s, 2);
            //Console.WriteLine(s);

            //Console.WriteLine("请输入数字1：");
            //Console.WriteLine("请输入数字2：");
            //string a = Console.ReadLine();
            //string b = Console.ReadLine();
            //int num1 = int .Parse(a);
            //int num2 = int .Parse(b);
            //int num3 = num1;
            //num1 = num2;
            //num2 = num3;
            //Console.WriteLine("数字1是:{0}，数字2是:{1}",num1,num2);

            //int a = 89;
            //int b = a / 24;
            //int c = a % 24;
            //Console.WriteLine("一共{0}天{1}小时",b,c);

            //Random r = new Random();
            //double num1 =  r.NextDouble();
            // num1 = Math.Round(num1,2);
            //Console.WriteLine(num1);

            //int n = 10;
            //int r = n++ + ++n + ++n + n++;
            //Console.WriteLine(r);
            //Console.WriteLine(n);
            //Console.WriteLine(++n);
            //Console.WriteLine(n++);

            // 1. 创建一个 长度为4的list, 类型字符串, 值为字母 ABCD
            // 2. 想最后添加一个 Z
            // 3. 向中间位置添加一个X
            // 4. 最后添加3个字母, QWE

            //List<string> arr1 = new List<string>() { "A","B","C","D" };
            //arr1.Add("z");
            //arr1.Insert(2, "x");
            //arr1.AddRange(["Q","W","E"]);
            //Console.WriteLine(arr1[8]);

            //Dictionary<dynamic, dynamic> game = new Dictionary<dynamic, dynamic>()
            //{
            //    ["a"] = 1,
            //    ["b"] = 2,
            //    ["c"] = 3

            //};
            //Console.WriteLine(game["c"]);
            //game["a"] = 4;
            //Console.WriteLine(game["a"]);


            // 随机点名
            /*
             需要将多个姓名放在一起 ==> List
             随机生成一个下标
             */
            // 使用List存放多个姓名
            //var r = new Random();
            //List<string> Name = new List<string>() { "a","b","c","d"};
            //Console.WriteLine(Name[r.Next(0,Name.Count)]);

            //Dictionary<string,dynamic> zd = new Dictionary<string, dynamic>() 
            //{
            //    ["name"] = "leno",
            //    ["age"]  = 18,
            //    ["like"] = "football",
            //};
            //Console.WriteLine(zd.TryGetValue("name",out dynamic v));
            //int[] a = [1,2,3];
            //Console.WriteLine(a[0]);
            //Console.WriteLine(a[1]);
            //Console.WriteLine(a[2]);

            //Console.WriteLine("请输入年龄：");
            //int a = int.Parse(Console.ReadLine());
            //string w = a >= 18 ? "成年" : "未成年";
            //Console.WriteLine(w);

            //根据输入的成绩判断是不及格(小于60),及格(大于60小于80), 良好(大于80小于90),优秀(大于90小于100)
            //Console.WriteLine("请输入分数（1`100）");
            //int a = int.Parse(Console.ReadLine());
            //if (a >= 0 && a < 60)
            //{
            //    Console.WriteLine($"{a}--不及格");
            //}
            //else if (a < 80)
            //{
            //    Console.WriteLine($"{a}--及格");
            //}
            //else if (a < 90)
            //{
            //    Console.WriteLine($"{a}--良好");
            //}
            //else if (a <= 100)
            //{
            //    Console.WriteLine($"{a}--优秀");
            //}
            //else
            //{
            //    Console.WriteLine("请重新输入分数（1~100）");
            //}
            //输入年份，判断是否是闰年(普通闰年：能被4整除但不能被100整除 / 世纪闰年：可以被400整除)


            //Console.WriteLine("请输入分数");
            //int n = int.Parse(Console.ReadLine());
            //if (n >= 0 && n <= 100) {
            //    int num = n / 10;
            //    switch (num)
            //    {
            //        case 0:
            //        case 1:
            //        case 2:
            //        case 3:
            //        case 4:
            //        case 5: Console.WriteLine("分数等级是F"); break;
            //        case 6: Console.WriteLine("分数等级是D"); break;
            //        case 7: Console.WriteLine("分数等级是C"); break;
            //        case 8: Console.WriteLine("分数等级是B"); break;
            //        case 9:
            //        case 10: Console.WriteLine("分数等级是A"); break;
            //    }
            //}
            //else 
            //{
            //    Console.WriteLine("分数有误");

            //switch简写
            //Console.WriteLine("请输入分数");
            //int n = int.Parse(Console.ReadLine());
            //if (n >= 0 && n <= 100) {
            //    string res = n switch
            //    {
            //        >= 90 => "a",
            //        >= 80 => "b",
            //        >= 70 => "c",
            //        >= 60 => "d",
            //        _ => "f",
            //    };
            //    Console.WriteLine(res);
            //}

            //Console.WriteLine("请输入年份");
            //int a = int.Parse(Console.ReadLine());
            //string res = a % 4 == 0 && a % 100 != 0 || a % 400 == 0 ? "闰年" : "平年";
            //Console.WriteLine(res);
        }
    }
}

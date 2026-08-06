using System.Globalization;

namespace ConsoleApp2
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

            //Console.WriteLine("请输入账号");
            //string A = Console.ReadLine();
            //Console.WriteLine("请输入密码");
            //string B = Console.ReadLine();
            //if (A != "admin") Console.WriteLine("账号不存在");
            //else if (B != "123456") Console.WriteLine("密码错误");
            //else Console.WriteLine("登入成功");

            //Console.WriteLine("请选择 add/edit/del");
            //string S = Console.ReadLine();
            //var A = S switch 
            //{ 
            //"add"  => "新增成功",
            //"edit" => "修改成功",
            //"del"  => "删除成功",
            //};
            //Console.WriteLine(A);


            //string S = Console.ReadLine();
            //int A = int.Parse(Console.ReadLine());
            //if (S == "vip")
            //{
            //    if (A < 1000)
            //    {
            //        Console.WriteLine(A);
            //    }
            //    else
            //    {
            //        Console.WriteLine(A * 0.9);
            //    }
            //}
            //else
            //{
            //    if (A < 2000)
            //    {
            //        Console.WriteLine(A);
            //    }
            //    else
            //    {
            //        Console.WriteLine(A * 0.95);
            //    }
            //}


            //Console.WriteLine("请输入月份：");
            //int m = int.Parse(Console.ReadLine());
            //switch (m)
            //{
            //    case 3:
            //    case 4:
            //    case 5:
            //        Console.WriteLine("春季");
            //        break;
            //    case 6:
            //    case 7:
            //    case 8:
            //        Console.WriteLine("夏季");
            //        break;
            //    case 9:
            //    case 10:
            //    case 11:
            //        Console.WriteLine("秋季");
            //        break;
            //    case 12:
            //    case 1:
            //    case 2:
            //        Console.WriteLine("冬季");
            //        break;
            //    default:
            //        Console.WriteLine("月份输入不对");
            //        break;
            //}

            //Console.WriteLine("请输入快递重量（KG）:");
            //double g = double.Parse(Console.ReadLine());

            //double price;
            //if (g < 1)
            //{
            //    price = 10;
            //    Console.WriteLine("快递费：" + price);
            //}
            //else if (g <= 5)
            //{
            //    price = 20;
            //    Console.WriteLine("快递费：" + price);
            //}
            //else if (g > 5)
            //{
            //    price = 50;
            //    Console.WriteLine("快递费：" + price);
            //}

            //Console.WriteLine("输入会员等级（3-5的整数）：");
            //int level = int.Parse(Console.ReadLine());
            //switch (level)
            //{
            //    case 5:
            //        Console.WriteLine("终身免运费");
            //        break;
            //    case 4:
            //        Console.WriteLine("每月可领优惠卷");
            //        break;
            //    case 3:
            //        Console.WriteLine("购物打9折");
            //        break;
            //    default:
            //        Console.WriteLine("没有福利");
            //        break;
            //}

            //Console.WriteLine("输入商品编号：");
            //int bianhao = int.Parse(Console.ReadLine());
            //switch (bianhao)
            //{
            //    case 1:
            //        Console.WriteLine("已购买可乐");
            //        break;

            //    case 2:
            //        Console.WriteLine("已购买雪碧");
            //        break;

            //    case 3:
            //        Console.WriteLine("已购买矿泉水");
            //        break;
            //    default:
            //        Console.WriteLine("无此商品");
            //        break;
            //}

            //Console.WriteLine("输入当前速度：");
            //double speed = double.Parse(Console.ReadLine());
            //if (speed > 0 && speed <= 30)
            //{
            //    Console.WriteLine("低速通过");

            //}
            //else if (speed <= 60)
            //{
            //    Console.WriteLine("中速通过");
            //}
            //else if (speed <= 100)
            //{
            //    Console.WriteLine("高速通过");
            //}
            //else if (speed <= 120)
            //{
            //    Console.WriteLine("超速通过");
            //}

            //int i = 1;
            //int sum = 0;
            //while(i<=10){
            //    sum += i;
            //    i++;
            //}
            //Console.WriteLine(sum);

            //1
            //int sum = 0;
            //for(int a = 0; a <= 100; a += 2)
            //{
            //     sum += a;
            //}
            //Console.WriteLine(sum);

            //2
            //int i = 1000;
            //int n = 0;
            //while (i <= 2000)
            //{
            //    if (i%4==0 && i%100!=0 || i % 400 == 0)
            //    {
            //        if (n % 4 == 0)
            //        {
            //            Console.WriteLine();
            //        }
            //        n++;
            //        Console.Write($"{i} ");
            //    }
            //    i++;
            //}


            //3
            //int n = 9;
            //while (n >= 0)
            //{
            //    int i = 1;
            //    while (i <= n)
            //    {
            //        Console.Write("*");
            //        i++;
            //    }
            //    Console.WriteLine("");
            //    n--;
            //}

            //4
            //double i = 1;
            //for(double a = 2; a <= 100; a++)
            //{
            //    if (a % 2 == 0)
            //    {
            //        i = i + (1 / a * -1);
            //    }
            //    else
            //    {
            //        i = i + 1 / a;
            //    }
            //}
            //Console.WriteLine(i);


            //5
            //long sum = 1;
            //long num = 0;
            //int a = 1;
            //    while (a <= 20)
            //    {
            //    sum *= a;
            //    num += sum;
            //    a++;
            //}
            //Console.WriteLine(num);

            //for (int i = 9; i >= 0; i--) 
            //{
            //    for (int j = 1; j <= i; j++) 
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine("*");
            //}

            //6
            //double a = 5;
            //double b = 1;
            //for (; a >= 0.1; b++)
            //{
            //    a*=Math.Pow(0.3,b);
            //}
            //Console.WriteLine(b);

            //7
            //double a = 0;
            //for (double i = 0; i < 64; i++)
            //{
            //    a +=  Math.Pow(2, i);
            //}
            //double c = a * 0.00001;
            //Console.WriteLine(c);

            //8
            //double i = 50000;
            //int a = 0;

            //while (i >= 5000) 
            //{
            //    Console.WriteLine($"{i},{a}");
            //    i = i - i * 0.05;
            //    a++;
            //}

            //9
            //int a = 1;
            //for (int i = 1; i < 7; i++)
            //{
            //    a = (a + 1) * 2;
            //}
            //Console.WriteLine(a);

            //10
            //double a = 0;
            //for (int i = 1; i <= 9; i++)
            //{
            //    a += 10 / Math.Pow(2, i);
            //}
            //double b = a * 2 + 10;
            //Console.WriteLine(b);


        }
    }
}


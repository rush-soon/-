namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
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

            int n = 10;
            int r = n++ + ++n + ++n + n++;
            Console.WriteLine(r);
            Console.WriteLine(n);
            Console.WriteLine(++n);
            Console.WriteLine(n++);
        }
    }
}

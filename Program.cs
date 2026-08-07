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


            //Dictionary<dynamic, dynamic> dic = new Dictionary<dynamic, dynamic>()
            //{
            //    ["name"] = "nige",
            //    ["age"]  =  18,
            //    ["gender"] = "man",
            //};
            //Console.WriteLine(dic.TryAdd("atm",10000));
            //foreach(dynamic d in dic) 
            //{
            //    Console.WriteLine(d);
            //}

            //List<string> list = new List<string>()
            //{
            //    "a","b","a","b","a","b"
            //};
            //for(int i = 0; i < list.Count; i++)
            //{
            //    for(int j = i + 1; j < list.Count; j++)
            //    {
            //        if (list[i] == list[j])
            //        {
            //             list.RemoveAt(j);
            //            j--;
            //        }
            //    }
            //}
            //foreach (string s in list) {
            //    Console.WriteLine(s);
            //}

            //int n = 0;
            //for (int i = 1000; i <= 2000;)
            //{
            //    if (i % 4 == 0)
            //        Console.Write($"{i} ");
            //    i++;
            //    n++;
            //    if (n % 4 == 0)
            //    Console.WriteLine();

            //List<int> fors = new List<int>()
            //{
            //    1,2,3,4,5,6,7,7,6,5,4,3,2,1,
            //};
            //List<int> fors2 = new List<int>();
            //foreach(var i in fors)
            //{
            //    if (!fors2.Contains(i))
            //    {
            //        fors2.Add(i);
            //    }
            //}
            //foreach(var a in fors2)
            //{
            //    Console.Write(a);
            //}

            //List<int> list = new()
            //{
            //    1,2,3,4,5,6,7,8,9,8,7,6,5,4,3,2,1
            //};

            //for(int i = 0; i < list.Count; i++)
            //{
            //    int a = list.LastIndexOf(list[i]);
            //    if (list.LastIndexOf(list[i]) != i)
            //        list.RemoveAt(a);
            //}
            //foreach(int b in list)
            //{
            //    Console.WriteLine(b);
            //}

            //Dictionary<int, dynamic> dic = new ();
            //foreach (int i in list)
            //{

            //    dic[i] = " ";
            //}
            //List<int> newList = new List<int>();
            //newList = dic.Keys.ToList();
            //foreach (int i in newList)
            //{
            //    Console.WriteLine(i);
            //}

            //for(int i = 0; i < list.Count-1; i++)
            //{
            //    for(int j = 0; j < list.Count-1-i; j++)
            //    {
            //        if(list[j] > list[j + 1])
            //        {
            //            int num = list[j];
            //            list[j]=list[j+1];
            //            list[j+1]=num;
            //        }
            //    }
            //}
            //foreach(int b in list)
            //{
            //    Console.WriteLine(b);
            //}


            //作业
            // 提示输入的 是price还是stock  排序类型 
            // 提示输入的是 ASC 还是DSC     排序顺序(ASC升序,DSC降序)
            // 根据输入完成数据排序

            //List<Dictionary<string, dynamic>> goodsList = new List<Dictionary<string, dynamic>>
            //    {
            //        new Dictionary<string, dynamic>
            //        {
            //            {"name", "机械键盘"},
            //            {"price", 299.99},
            //            {"code", "G001"},
            //            {"stock", 120}
            //        },
            //        new Dictionary<string, dynamic>
            //        {
            //            {"name", "无线鼠标"},
            //            {"price", 89.50},
            //            {"code", "G002"},
            //            {"stock", 356}
            //        },
            //        new Dictionary<string, dynamic>
            //        {
            //            {"name", "27寸显示器"},
            //            {"price", 1299.00},
            //            {"code", "G003"},
            //            {"stock", 48}
            //        },
            //        new Dictionary<string, dynamic>
            //        {
            //            {"name", "电竞耳机"},
            //            {"price", 199.00},
            //            {"code", "G004"},
            //            {"stock", 85}
            //        },
            //        new Dictionary<string, dynamic>
            //        {
            //            {"name", "电脑支架"},
            //            {"price", 69.90},
            //            {"code", "G005"},
            //            {"stock", 210}
            //        }
            //    };
            //    Console.WriteLine("请选择排序类型（price/stock）");
            //    string paixuleixing = Console.ReadLine();
            //    Console.WriteLine("请选择排序顺序（ACE/DSC）");
            //    string paixushunxu = Console.ReadLine();

            //           for (int j = 0; j < goodsList.Count - 1; j++)
            //            {
            //                for (int i = 0; i < goodsList.Count - 1; i++)
            //                {
            //                    if (goodsList[i][paixuleixing] > goodsList[i + 1][paixuleixing])
            //                    {
            //                        var tmp = goodsList[i];
            //                        goodsList[i] = goodsList[i + 1];
            //                        goodsList[i + 1] = tmp;
            //                    }

            //                }
            //             }
            //    if (paixushunxu == "ACE")
            //    {
            //        foreach(var n in goodsList)
            //        Console.WriteLine(n["name"]+"  " + n[paixuleixing]);
            //    }
            //    else if (paixushunxu == "DSC")
            //    {
            //        goodsList.Reverse();
            //        foreach (var n in goodsList)
            //            Console.WriteLine(n["name"] + "  " + n[paixuleixing]);
            //    }

            //List<Dictionary<string, dynamic>> singerList = new List<Dictionary<string, dynamic>>
            //{
            //    new Dictionary<string, dynamic>
            //    {
            //        {"singerId", 1001},
            //        {"singerName", "周杰伦"},
            //        {"genre", "流行"}
            //    },
            //    new Dictionary<string, dynamic>
            //    {
            //        {"singerId", 1002},
            //        {"singerName", "林俊杰"},
            //        {"genre", "华语流行"}
            //    },
            //    new Dictionary<string, dynamic>
            //    {
            //        {"singerId", 1003},
            //        {"singerName", "邓紫棋"},
            //        {"genre", "流行、摇滚"}
            //    },
            //    new Dictionary<string, dynamic>
            //    {
            //        {"singerId", 1004},
            //        {"singerName", "薛之谦"},
            //        {"genre", "抒情流行"}
            //    },
            //    new Dictionary<string, dynamic>
            //    {
            //        {"singerId", 1005},
            //        {"singerName", "毛不易"},
            //        {"genre", "民谣流行"}
            //    }
            //};

            //List<Dictionary<string, dynamic>> songList = new List<Dictionary<string, dynamic>>
            //{
            //    new Dictionary<string, dynamic>
            //    {
            //        {"songId", 10001},
            //        {"singerId", 1001},
            //        {"songName", "青花瓷"},
            //        {"duration", 239}
            //    },
            //    new Dictionary<string, dynamic>
            //    {
            //        {"songId", 10002},
            //        {"singerId", 1001},
            //        {"songName", "发如雪"},
            //        {"duration", 253}
            //    },
            //    new Dictionary<string, dynamic>
            //    {
            //        {"songId", 10003},
            //        {"singerId", 1001},
            //        {"songName", "东风破"},
            //        {"duration", 215}
            //    },
            //    new Dictionary<string, dynamic>
            //    {
            //        {"songId", 1004},
            //        {"singerId", 3002},
            //        {"songName", "不为谁而作的歌"},
            //        {"duration", 296}
            //    },
            //    new Dictionary<string, dynamic>
            //    {
            //        {"songId", 1005},
            //        {"singerId", 1002},
            //        {"songName", "背对背拥抱"},
            //        {"duration", 262}
            //    }
            //};

            //Console.WriteLine("请输入歌曲：");
            //string song = Console.ReadLine();
            //int singerSongId = 0;
            //if (song != null)
            //{
            //    foreach (dynamic songs in songList)
            //    {
            //        if (songs["songName"] == song)
            //        {
            //            singerSongId = songs["singerId"];
            //        }
            //    }
            //    foreach (dynamic singerid in singerList)
            //    {
            //        if (singerSongId == singerid["singerId"])
            //        {
            //            Console.WriteLine(singerid["singerName"]);
            //        }

            //    }
            //}
        }
    }
}


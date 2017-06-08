using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenCvSharp;

namespace sample_app
{
    class Program
    {
        static void Main(string[] args)
        {
            Mat dst = new Mat(2,2, MatType.CV_64FC(1));
            dst.Set<double>(0, 0, 10);
            dst.Set<double>(1, 0, 20);
            dst.Set<double>(0, 1, 30);
            dst.Set<double>(1, 1, 40);
            Console.WriteLine(dst.Get<double>(0, 1));

            //Sample702();

            Console.WriteLine("HelloWorld.");
        }

        static void Sample101()
        {
            Console.WriteLine("HelloWorld.");
        }

        static void Sample102()
        {
            Console.Write(123);
            Console.WriteLine(456);
        }

        static void Sample201()
        {
            Console.WriteLine("{0} + {1} = {2}", 5, 2, 5 + 2);
        }

        static void Sample202()
        {
            int a;
            int b = 3;
            int add, sub;
            double avg;

            a = 6;
            add = a + b;
            sub = a - b;
            avg = add / 2.0;
            Console.WriteLine("{0} + {1} = {2}", a, b, add);
            Console.WriteLine("{0} - {1} = {2}", a, b, sub);
            Console.WriteLine("{0}と{1}の平均値{2}", a, b, avg);
        }

        static void Sample205()
        {
            string str1, str2;
            Console.Write("str1=");
            str1 = Console.ReadLine();
            Console.Write("str2=");
            str2 = Console.ReadLine();
            Console.WriteLine("str1 + str2  = {0}", str1 + str2);

        }

        static void Sample301()
        {
            Console.Write("整数値を入力：");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("a=" + a);

            if(a>0)
            {
                Console.WriteLine("aは正の数です。");
            } else
            {
                Console.WriteLine("aは0以下の数です。");
            }
            
        }

        static void Sample502()
        {
            /*
            double[] d = new double[3];
            d[0] = 1.2;
            d[1] = 3.7;
            d[2] = 4.1;
            */
            double[] d = { 1.2, 3.7, 4.1 };
            double sum = 0;
            double avg;

            for(int i=0; i< d.Length; i++)
            {
                Console.Write(d[i] + " ");
                sum += d[i];
            }

            Console.WriteLine();
            avg = sum / d.Length;
            Console.WriteLine("合計値：" + sum);
            Console.WriteLine("平均値：" + avg);
        }

        static void Sample601()
        {
            Person p1, p2;
            p1 = new Person();
            p2 = new Person();
            p1.name = "山田太郎";
            p1.age = 19;
            p2.SetAgeAndName("佐藤花子", 23);
            p1.ShowAgeAndName();
            p2.ShowAgeAndName();
        }

        static void Sample602()
        {
            Calc calc = new Calc();
            int ans1 = calc.Add(1, 2);
            int ans2 = calc.Add(1, 2, 3);

            Console.WriteLine(ans1);
            Console.WriteLine(ans2);
        }

        static void Sample702()
        {
            Access a = new Access();
            a.Data2 = 2;
            a.ShowDatas();
            Console.WriteLine("a.data1 = {0}", a.Data1);
            //Console.WriteLine("a.data2 = {0}", a.Data2);
        }
    }
    
}

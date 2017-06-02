using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sample_app
{
    class Program
    {
        static void Main(string[] args)
        {
            Sample301();

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
    }
}

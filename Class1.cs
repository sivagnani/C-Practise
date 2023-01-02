using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise
{
    public class Sample1
    {
        public static int Test()
        {
            Console.WriteLine("Sample1");
            int x = 12 * 30;
            Console.WriteLine(x);
            return 0;
        }
    }
    public class Sample2
    {
        public static int Test()
        {
            Console.WriteLine("Sample2");
            Console.WriteLine(FI(30));
            Console.WriteLine(FI(120));
            return 0;
        }
        static int FI(int x)
        {
            return x * 12;
        }
    }
    public class UC
    {
        int ratio;
        public UC(int unitRatio) { ratio = unitRatio; }
        public int Convert(int unit) { return unit * ratio; }
    }
    public class Sample3
    {
        
        public static int Test()
        {
            Console.WriteLine("Custom Type and pass by value");
            UC fc = new UC(12);
            UC mf = new UC(5280);
            Console.WriteLine(fc.Convert(30));
            Console.WriteLine(fc.Convert(100));
            Console.WriteLine(fc.Convert(mf.Convert(1)));
            return 0;
        }
    }
    public class Sample4
    {
        static void Foo(int ab){
            ab = 123;
        }
        public static int Test()
        {
            int a = new int();
            Console.WriteLine("Pass by reference");
            Foo(a);
            Console.WriteLine(a);
            return 0;
        }
    }
    public class Sample5
    {
        static void Foo(ref int ab)
        {
            ab = 123;
        }
        public static int Test()
        {
            int a = new int();
            Console.WriteLine("Pass by reference modifier");
            Foo(ref a);
            Console.WriteLine(a);
            return 0;
        }
    }
    public class Sample6
    {
        static void Foo(out int ab)
        {
            ab = 123;
        }
        public static int Test()
        {
            int a;
            Console.WriteLine("Pass by reference modifier using out");
            Foo(out a);
            Console.WriteLine(a);
            return 0;
        }
    }
    public class Sample7
    {
        static int Foo(params int[] ab)
        {
            int sum = 0;
            for (int i = 0; i < ab.Length; i++)
                sum += ab[i];
            return sum;
        }
        public static int Test()
        {
            Console.WriteLine("Using params");
            Console.WriteLine(Foo(1,3,5,7));
            return 0;
        }
    }
    public class Sample8
    {
        public static int Test()
        {
            Console.WriteLine("Using if and else");
            int a = 5;
            if (a < 2 * 3)
                Console.WriteLine("if block");
            else
                Console.WriteLine("else block");
            if (a > 2 * 3)
                Console.WriteLine("If block2");
            else
                Console.WriteLine("else block2");
            return 0;
        }
    }
    public class Sample9
    {
        public static int Test()
        {
            Console.WriteLine("Using switch");
            int a = 5;
            switch(a)
            {
                case 0: Console.WriteLine("0"); break;
                case 1: Console.WriteLine("1"); break;
                case 2: Console.WriteLine("2"); break;
                case 3: Console.WriteLine("3"); break;
                case 4: Console.WriteLine("4"); break;
                case 5: Console.WriteLine("5"); goto case 3;
                default: Console.WriteLine("not between 0-5"); break;
            }
            return 0;
        }
    }
    public class Sample10
    { 
        public static int Test()
        {
            Console.WriteLine("While");
            int a = 0;
            while (a < 5)
            {
                Console.WriteLine(a);
                a++;
            }
            return 0;
        }
        public static int Test1()
        {
            Console.WriteLine("do While");
            int a = 0;
            do
            {
                Console.WriteLine(a);
                a++;
            }
            while (a < 5);
            return 0;
        }
        public static int Test2()
        {
            Console.WriteLine("for");
            for(int i=0; i < 5;i++)
            {
                Console.WriteLine(i);
            }
            return 0;
        }
        public static int Test3()
        {
            Console.WriteLine("foreach");
            foreach(char a in "india")
            {
                Console.WriteLine(a);
            }
            return 0;
        }


    }
}

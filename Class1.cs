using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//single line comment
/*doublle line
 comments*/

namespace Practise
{
    public class Sample1
    {
        public static void Test()
        {
            Console.WriteLine("Sample1");
            int x = 12 * 30;
            Console.WriteLine(x);
        }
    }
    public class Sample2
    {
        public static void Test()
        {
            Console.WriteLine("Sample2");
            Console.WriteLine(FI(30));
            Console.WriteLine(FI(120));
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

        public static void Test()
        {
            Console.WriteLine("Custom Type and pass by value");
            UC fc = new UC(12);
            UC mf = new UC(5280);
            Console.WriteLine(fc.Convert(30));
            Console.WriteLine(fc.Convert(100));
            Console.WriteLine(fc.Convert(mf.Convert(1)));
        }
    }
    public class StaticAndInstance
    {
        public string name;
        public static int population;
        public StaticAndInstance(string s)
        {
            Console.WriteLine("Example for static and instance");
            name = s;
            population = population + 1 ;
        }
    }
    public class Checkingchecked
    {
        
        public Checkingchecked()
        {
            Console.WriteLine(unchecked(int.MinValue - 2));
        }
    }
    public class Passbyref
    {
        static void Foo(int ab)
        {
            ab = 123;
        }
        public static void Test()
        {
            int a = new int();
            Console.WriteLine("Pass by reference");
            Foo(a);
            Console.WriteLine(a);
        }
    }
    public class Passbyrefmodifier
    {
        static void Foo(ref int ab)
        {
            ab = 123;
        }
        public static void Test()
        {
            int a = new int();
            Console.WriteLine("Pass by reference modifier");
            Foo(ref a);
            Console.WriteLine(a);
        }
    }
    public class Passbyrefusingout
    {
        static void Foo(out int ab, out int c )
        {
            ab = 123;
            c = 234;
        }
        public static void Test()
        {
            int a;
            Console.WriteLine("Pass by reference modifier using out");
            Foo(out a,out _);
            Console.WriteLine(a);
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
        public static void Test()
        {
            Console.WriteLine("Using params");
            Console.WriteLine(Foo(1, 3, 5, 7));
        }
    }
    public class Sample8
    {
        public static void Test()
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
        }
    }
    public class Sample9
    {
        public static void Test()
        {
            Console.WriteLine("Using switch");
            int a = 5;
            switch (a)
            {
                case 0: Console.WriteLine("0"); break;
                case 1: Console.WriteLine("1"); break;
                case 2: Console.WriteLine("2"); break;
                case 3: Console.WriteLine("3"); break;
                case 4: Console.WriteLine("4"); break;
                case 5: Console.WriteLine("5"); goto case 3;
                default: Console.WriteLine("not between 0-5"); break;
            }
        }
    }
    public class Sample10
    {
        public static void Test()
        {
            Console.WriteLine("While");
            int a = 0;
            while (a < 5)
            {
                Console.WriteLine(a);
                a++;
            }
        }
        public static void Test1()
        {
            Console.WriteLine("do While");
            int a = 0;
            do
            {
                Console.WriteLine(a);
                a++;
            }
            while (a < 5);
        }
        public static void Test2()
        {
            Console.WriteLine("for");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
            }
        }
        public static void Test3()
        {
            Console.WriteLine("foreach");
            foreach (char a in "india")
            {
                Console.WriteLine(a);
            }
        }
    }
    public class Sample11
    {
        public readonly float Width, Height;

        public Sample11(float width, float height)
        {
            Width = width;
            Height = height;
        }
        public void Deconstruct(out float width, out float height)
        {
            Console.WriteLine("Deconstruct");
            width = Width;
            height = Height;
        }
    }
    public class Stock
    {
        decimal dc;
        public decimal Dc
        {
            get
            {
                return dc;
            }
            set
            {
                dc = value;
            }
        }
    }
    public class StockAuto
    {
        public decimal Dc
        {
            get;
            set;
        }
    }
    public class Indexer
    {
        string[] w = "Hi guys this is technovert".Split();
        public string this[int num]
        {
            get => w[num];
            set => w[num] = value;
        }
    }
    public class StaticCons
    {
        static StaticCons()
        {
            Console.WriteLine("Static Constructor");
        }
    }
    public partial class ParC
    {
        public static partial void test2();
        public static void test()
        {
            Console.WriteLine("Partial Class 1");
        }
    }
    public partial class ParC
    {
        public static partial void test2()
        {
            Console.WriteLine("Partial Class 2");
            Console.WriteLine("Partial Method 1");
        }
    }
    public class Asset
    {
        public string name;
    }
    public class Stocks : Asset
    {
        public long shares;
    }
    public class House : Asset
    {
        public decimal Mortage;
    }
    
}

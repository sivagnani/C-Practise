using System;
using Practise;
class Test2
{
	static void Main(string[] args)
	{
		Sample1.Test();
        Sample2.Test();
		Sample3.Test();
		StaticAndInstance sai = new StaticAndInstance("siva");
		StaticAndInstance sai2 = new StaticAndInstance("gnani");
		StaticAndInstance sai1 = sai;
		Console.WriteLine(sai.name);
		Console.WriteLine(sai1.name);
		sai.name = "MSG";
		Console.WriteLine(sai1.name);
        Console.WriteLine(StaticAndInstance.population);
		Checkingchecked cc = new Checkingchecked();
        Passbyref.Test();
		Passbyrefmodifier.Test();
		Passbyrefusingout.Test();
		Sample7.Test();
		Sample8.Test();
		Sample9.Test();
		Sample10.Test();
        Sample10.Test1();
        Sample10.Test2();
        Sample10.Test3();
		var a = new Sample11(2,3);
		(float width, float height) = a;
		Console.WriteLine("Using properties");
		Stock ms = new Stock();
		ms.Dc = 30;
        StockAuto m = new StockAuto();
        m.Dc = 20;
        Console.WriteLine(m.Dc);
		Console.WriteLine("Using Indexers");
		Indexer i = new Indexer();
		Console.WriteLine(i[2]);
		i[2] = "that";
		Console.WriteLine(i[2]);
		StaticCons sc1 = new StaticCons();
		StaticCons sc2 = new StaticCons();
		ParC.test();
		ParC.test2();
		int count = 123;
		Console.WriteLine("Üsing name of :"+nameof(count));
		Console.WriteLine("Inheritance");
		Stocks msf = new Stocks {name = "Tech", shares = 1000};
		Console.WriteLine(msf.name);
		Console.WriteLine(msf.shares);
		Console.WriteLine("Polymorphism");
		display(msf);
		
    }
    static void display(Asset a)
    {
        Console.WriteLine(a.name);
    }
}

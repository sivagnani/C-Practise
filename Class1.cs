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
            int x = 12 * 30;
            Console.WriteLine(x);
            return 0;
        }
    }
    public class Sample2
    {
        public static int Test()
        {
            Console.WriteLine(FI(30));
            Console.WriteLine(FI(120));
            return 0;
        }
        static int FI(int x)
        {
            return x * 12;
        }
    }
}

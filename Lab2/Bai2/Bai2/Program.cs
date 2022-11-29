using System;

namespace Bai2
{
    class Program
    {
        class phanso
        {
            private static int i;
            public void seti(int n)  { i = n; }
            public int geti()  { return i; }
        }
        static void Main(string[] args)
        {
            phanso ob1 = new phanso();
            phanso ob2 = new phanso();
            ob1.seti(33);
            Console.WriteLine("Gia tri ob1:{0}", ob1.geti());
            Console.WriteLine("gia tri ob2:{0}", ob2.geti());
        }
    }
}

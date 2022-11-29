using System;

namespace Bai3
{
    class Program
    {
        class tienich
        {
            int i;
            public static long LuyThua(int CoSo,int SoMu)
            {
                long Ketqua = 1;
                for (int i = 0; i < SoMu; i++)
                {
                    Ketqua *= CoSo;
                }
                return Ketqua;

            }
            public static int UCLN(int a,int b)
            { 
                a = Math.Abs(a);
                b = Math.Abs(b);
                while(a != b)
                {
                    if (a > b)
                        a = a - b;
                    if (a < b)
                        b = b - a;
                }
                return a;
            }
            public static int BSCNN(int a,int b)
            {
                return (a * b) / UCLN(a, b);
            }
            
        }
        static void Main(string[] args)
        {
            Console.WriteLine(tienich.LuyThua(2,5));
            Console.WriteLine(tienich.UCLN(15,3));
            Console.WriteLine(tienich.BSCNN(2, 3));
            Console.ReadLine();
        }
    }
}

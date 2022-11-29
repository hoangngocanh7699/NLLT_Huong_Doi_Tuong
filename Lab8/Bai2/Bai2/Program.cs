using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        public class cosothaplucphan
        {
            private int[] _hx = new int[17];
            public int[] hx { get { return _hx; } set { _hx = value; } }
            public void DoiSoThapLucPhan()
            {
                int inp = input();
                int t = 0;
                int sd;
                while (true)
                {
                    sd = inp % 16;
                    inp /= 16;
                    if (inp == 0)
                    {
                        hx[t] = sd;
                        break;
                    }
                    hx[t] = sd;
                    t++;
                }
            }
            public int input()
            {
                int inp;
                Console.Write("Nhap: ");
                inp = Int32.Parse(Console.ReadLine());
                return inp;
            }
            public void output()
            {
                var temp = 0;
                Console.Write("day thap luc phan : ");
                for (int i = hx.Length - 1; i < hx.Length && i >= 0; i--)
                {
                    if (hx[i] >= 10)
                    {
                        switch (hx[i])
                        {
                            case 10: { Console.Write("A"); break; }
                            case 11: { Console.Write("B"); break; }
                            case 12: { Console.Write("C"); break; }
                            case 13: { Console.Write("D"); break; }
                            case 14: { Console.Write("E"); break; }
                            case 15: { Console.Write("F"); break; }
                        }
                    }
                    else Console.Write(hx[i]);
                }
            }


            public static cosothaplucphan operator +(cosothaplucphan a, cosothaplucphan b)
            {
                int nho = 0;
                cosothaplucphan c = new cosothaplucphan();
                for (int i = 7; i > 0; i--)
                {
                    c._hx[i] = a._hx[i] + b._hx[i] + nho;
                    if (c._hx[i] > 15)
                    {
                        c._hx[i] = 15;
                        nho = c._hx[i] - 15;
                    }
                    else
                        nho = 0;
                }
                return c;
            }

        }
        static void Main(string[] args)
        {
            cosothaplucphan a = new cosothaplucphan();
            cosothaplucphan b = new cosothaplucphan();
            cosothaplucphan c = new cosothaplucphan();
            a.DoiSoThapLucPhan();
            b.DoiSoThapLucPhan();


            c = a + b;

            a.output();
            b.output();
            c.output();
        }
    }


}
using System;

namespace bt
{
    class Program
    {
        class phanso
        {
            int tuso;
            int mauso;
            bool dau;
            public phanso()
            {
                tuso = 0;
                mauso = 1;
                dau = true;
            }
            public phanso(int ts, int ms)
            {
                if (ts < 0 && ms > 0 || ts > 0 && ms < 0)
                {
                    dau = false;
                }
                else dau = true;
                tuso = System.Math.Abs(ts);
                if (ms >= 0)
                    dau = dau && true; //sai
                else
                    dau = dau && false; //sai
                mauso = System.Math.Abs(ms);
            }
            public static phanso nhapphanso()
            {
                int Ts, Ms;
                bool kiemtra = false;
                Console.WriteLine("Nhap vao phan so:");
                do
                {
                    Console.Write("tu so = ");
                    kiemtra = Int32.TryParse(Console.ReadLine(), out Ts);
                } while (!kiemtra);
                do
                {
                    Console.Write("mau so = ");
                    kiemtra = Int32.TryParse(Console.ReadLine(), out Ms);
                    if (Ms == 0)
                        kiemtra = false;
                } while (!kiemtra);
                return new phanso(Ts, Ms);
            }
            public void xuat()
            {
                Console.Write("Phan so da nhap la: ");
                if (!dau)
                    Console.Write("-");
                Console.Write(tuso.ToString() + "/" + mauso.ToString());

            }
            public phanso Cong(phanso ps)
            {
                if (!dau)
                    tuso = -tuso;
                if (!ps.dau)

                    ps.tuso = -ps.tuso;
                int Ts = this.tuso * ps.mauso + this.mauso * ps.tuso;
                int Ms = this.mauso * ps.mauso;
                return new phanso(Ts, Ms);

            }
            public phanso Tru(phanso ps)
            {
                if (!dau)
                    tuso = -tuso;
                if (!ps.dau)

                    ps.tuso = -ps.tuso;
                int Ts = this.tuso * ps.mauso - this.mauso * ps.tuso;
                int Ms = this.mauso * ps.mauso;
                return new phanso(Ts, Ms);

            }
            public phanso Nhan(phanso ps)
            {
                if (!dau)
                    tuso = -tuso;
                if (!ps.dau)

                    ps.tuso = -ps.tuso;
                int Ts = this.tuso* ps.tuso;
                int Ms = this.mauso * ps.mauso;
                return new phanso(Ts, Ms);

            }
            public phanso Chia(phanso ps)
            {
                if (!dau)
                    tuso = -tuso;
                if (!ps.dau)

                    ps.tuso = -ps.tuso;
                int Ts = this.tuso * ps.mauso;
                int Ms = this.mauso * ps.tuso;
                return new phanso(Ts, Ms);

            }
        }
        static void Main(string[] args)
        {
            phanso p1 = new phanso();
            phanso p2 = new phanso();
            p1 = phanso.nhapphanso();
            p1.xuat();
            Console.WriteLine(" (phan so thu nhat)");
            Console.WriteLine("----------------------");
            p2 = phanso.nhapphanso();
            p2.xuat();
            Console.WriteLine(" (phan so thu hai)");
            Console.WriteLine("----------------------");

            phanso p3 = new phanso();
            p3 = p1.Cong(p2);
            p3.xuat();
            Console.WriteLine(" (toan tu cong)");

            
            p3 = p1.Tru(p2);
            p3.xuat();
            Console.WriteLine(" (toan tu tru)");

            
            p3 = p1.Nhan(p2);
            p3.xuat();
            Console.WriteLine(" (toan tu nhan)");

            
            p3 = p1.Chia(p2);
            p3.xuat();
            Console.WriteLine(" (toan tu chia)");
        }
    }
}

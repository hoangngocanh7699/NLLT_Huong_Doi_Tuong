using System;

namespace DaThuc
{
    struct SoHang
    {
        public int Hs;
        public int Mu;
    };
    class DaThuc
    {
        int Sopt; //So phan tu
        SoHang[] DT ;
        public DaThuc()
        {
                Sopt = 0;
                DT = new SoHang[100];
        }
        public void ThemSoHang(int heso, int somu)
        {
            DT[Sopt].Hs = heso;
            DT[Sopt].Mu = somu;
            Sopt++;
        }
        
        public void Nhap()
        {
            int Heso;
            int Somu;

            do
            {
                Console.WriteLine("Nhap vao he so va so mu, khi ket thuc nhap he so = 0 ");
                Heso = Int32.Parse(Console.ReadLine());
                Somu = Int32.Parse(Console.ReadLine());
                if (Heso != 0)
                {
                    ThemSoHang(Heso, Somu);
                }
            } while (Heso != 0);
            
            
            
            
        }
        public void xuat()
        {
            Console.Write("\nDA THUC: \n");
            for (int i = 0; i < Sopt; i++)
            {
                Console.Write("{0}X^{1} + ",DT[i].Hs,DT[i].Mu);
            }
        }
    
    //    public static DaThuc operator +(DaThuc x, DaThuc y)
    //    {
    //        DaThuc z = new DaThuc();
            
    //        for (int i = 0; i < x.n; i++)
    //        {
                

    //                z.dt[i] = x.dt[i] + y.dt[i];

                
    //        }
    //        return z;
    //    }
    //}
    //    /*public static DaThuc operator -(DaThuc f, DaThuc g)
    //    {
    //        DaThuc h = new DaThuc();
    //        int maxbac = Math.Max(f.n, h.n);
    //        h.n = maxbac;
    //        for (int i = 0; i <= h.n; i++)
    //        {
    //            h.dt[i] = f.dt[i] - g.dt[i];
    //        }
    //        return h;
    //    }*/
    }
    class Program
    {
        static void Main(string[] args)
        {
            DaThuc dt1 = new DaThuc();
            DaThuc dt2 = new DaThuc();
            dt1.Nhap();
            dt1.xuat();
            Console.WriteLine();
            dt2.Nhap();
            dt2.xuat();
            Console.WriteLine();
            Console.WriteLine("Toan tu +, - ");
            Console.ReadKey();
        }
    }
}

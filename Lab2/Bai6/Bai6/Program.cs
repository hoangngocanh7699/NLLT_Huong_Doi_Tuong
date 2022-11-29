using System;

namespace Bai6
{
    class phanso
    {
        //int Tu, Mau;
        //public phanso()
        //{
        //    Tu = 0;
        //    Mau = 1;
        //}
        //public phanso(int x)
        //{
        //    Tu = x;
        //    Mau = 1;
        //}
        //public phanso(int t,int m)
        //{
        //    Tu = t;
        //    Mau = m;
        //}
        //public void xuaphanso()
        //{
        //    Console.WriteLine("({0}/{1})", Tu, Mau);
        //}
        //public phanso cong(phanso ps2)
        //{
        //    int ts = Tu * ps2.Mau + Mau * ps2.Tu;
        //    int ms = Mau * ps2.Mau;
        //    return new phanso(ts, ms);
        //}
        //public phanso tru(phanso ps2)
        //{
        //    int ms = Mau * ps2.Mau;
        //    int ts = Tu * ps2.Mau - ps2.Tu * Mau;
        //    return new phanso(ts, ms);
        //}
        //public phanso nhan(phanso ps2)
        //{
        //    int ts = Tu * ps2.Tu;
        //    int ms = Mau * ps2.Mau;
        //    return new phanso(ts, ms);
        //}
        //public phanso chia(phanso ps2)
        //{
        //    int ts = Tu * ps2.Mau;
        //    int ms = Mau * ps2.Tu;
        //    return new phanso(ts, ms);
        //}
    }
    class Program
    {
        static void Main(string[] args)
        {
            //phanso p1 = new phanso(); //p1 = 0/1
            //Console.Write("Phan so p1: ");
            //p1.xuaphanso(); Console.WriteLine();

            //phanso p2 = new phanso(3); //p2 = 3/1
            //Console.Write("Phan so p2: ");
            //p2.xuaphanso();

            int tuso;
            bool a = false;
            while(!a)
            {
                Console.WriteLine("Nhap tu so: ");
                a = Int32.TryParse(Console.ReadLine(),out tuso);
            }

            int mauso;
            bool b = false;
            while (!b)
            {
                Console.WriteLine("Nhap mau so: ");
                b = Int32.TryParse(Console.ReadLine(),out mauso);
            }
           
            Console.Write("Phan so da nhap la:{0} ");
            Console.WriteLine();

            //p1 = p2.cong(p3); 
            //Console.Write("Tong cua (3/1) va "); p3.xuaphanso();
            //p1.xuaphanso();

            //p1 = p2.tru(p3);
            //Console.Write("Hieu cua (3/1) va "); p3.xuaphanso();
            //p1.xuaphanso();

            //p1 = p2.nhan(p3);
            //Console.Write("Tich cua (3/1) va "); p3.xuaphanso();
            //p1.xuaphanso();

            //p1 = p2.chia(p3);
            //Console.Write("Thuong cua (3/1) va "); p3.xuaphanso();
            //p1.xuaphanso();
        }
    }
}

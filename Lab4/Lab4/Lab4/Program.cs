using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class SoPhuc

    {
        private float a, b;


        public SoPhuc()
        {
            a = 0;
            b = 1;
        }
        public SoPhuc(float a, float b)
        {
            this.a = a;
            this.b = b;
        }
        public SoPhuc(SoPhuc sp1)
        {
            a = sp1.a;
            b = sp1.b;
        }
        // a +bi Số phức là số có dạng a+bi, trong đó a , b là các số thực, i là đơn vị ảo , với i2=-1.
        public void Nhap()
        {
            //Console.WriteLine("Ban nhap vao 1 so phuc");
            bool kiemtra;
            do
            {
                Console.WriteLine("Nhap a");
                kiemtra = float.TryParse(Console.ReadLine(), out a);
            }
            while (!kiemtra);
            do
            {
                Console.WriteLine("Nhap b");
                kiemtra = float.TryParse(Console.ReadLine(), out b);
            }
            while (!kiemtra);

        }
        public void Xuat()
        {
            Console.WriteLine("So phuc da nhap la: {0} + {1}i  ", a, b);

        }
        public void ktra()
        {
            while (a == 0 && b != 0)
            {
                Console.WriteLine("la so thuan ao");
            }
            while (a != 0 && b == 0)
            {
                Console.WriteLine("la so thuc");
            }
        }
        
        public static SoPhuc operator +(SoPhuc i, SoPhuc j)
        {
            SoPhuc temp = new SoPhuc();
            temp.a = i.a + j.a;
            temp.b = i.b + j.b;
            return temp;
        }
        public static SoPhuc operator -(SoPhuc i, SoPhuc j)
        {
            SoPhuc temp = new SoPhuc();
            temp.a = i.a - j.a;
            temp.b = i.b - j.b;
            return temp;
        }
        public static SoPhuc operator *(SoPhuc i, SoPhuc j)
        {
            SoPhuc temp = new SoPhuc();
            temp.a = i.a * j.a - i.b * j.b;
            temp.b = i.a * j.b + i.b * j.a;
            return temp;
        }
        public static SoPhuc operator /(SoPhuc i, SoPhuc j)
        {
            SoPhuc temp = new SoPhuc();
            temp.a = i.a * j.a - i.b * j.b;
            temp.b = i.a * j.b + i.b * j.a;
            return temp;
        }
        public static bool operator ==(SoPhuc ps1, SoPhuc ps2)
        {
            return (ps1.a * ps2.b == ps2.a * ps1.b);
        }
        public static bool operator !=(SoPhuc ps1, SoPhuc ps2)
        {
            return !(ps1 == ps2);
        }
        public void kt()
        {
            if (a != 0 && b !=0)
            
                Console.WriteLine("So phuc  {0} + {1}i  ", a, b);
            else
            if (a == 0 && b != 0)
                Console.WriteLine("So thuan ao  {0} + {1}i  ", a, b);
            else
                 if (a != 0 && b == 0)
                Console.WriteLine("So thuc  {0} + {1}i  ", a, b);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("So phuc thu nhat ");
            SoPhuc x = new SoPhuc();
            x.Nhap();
            x.Xuat();
            Console.WriteLine("---------------------------------");
            Console.WriteLine("So phuc thu hai ");
            SoPhuc y = new SoPhuc();
            y.Nhap();
            y.Xuat();
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Các phép toán +, -, *, / so phuc ");
            SoPhuc z = new SoPhuc();
            z = x + y;
            z.Xuat();
            z = x - y;
            z.Xuat();
            z = x * y;
            z.Xuat();
            z = x / y;
            z.Xuat();
            Console.WriteLine("---------------------------------");
            ///////ktra so phuc, thuan ao
            Console.Write("So thu nhat la: ");
            x.kt();
            Console.Write("So thu hai la:  ");
            y.kt();
            Console.WriteLine("---------------------------------");
            ////2 so co bang nhau khong
            if (x == y)
                Console.WriteLine("2 so phuc bang nhau");
            else
                Console.WriteLine("2 so phuc khong bang nhau");
            

        }
    }
}

using System;

namespace Bai1
{
    class Program
    {
        class Tamthuc
        {
            int a, b, c;
          public Tamthuc()
            {
                a = b = c = 0;
            }
           public Tamthuc(int a,int b ,int c)
            {
                this.a = a;
                this.b = b;
                this.c = c;
            }
            public Tamthuc(Tamthuc ob)
            {
                a = ob.a;
                b = ob.b;
                c = ob.c;
            }
            
            //public void nhap()
            //{
            //    bool kiemtra = false; //nguoi dung khong nhap duoc chu 
            //    while(!kiemtra)
            //    {
                    
            //        Console.Write("Nhap a: ");
            //        kiemtra = Int32.TryParse(Console.ReadLine(), out a);

            //    }
            //    while (a == 0)
            //    {
            //        Console.Write("Gia tri a khong duoc bang 0, vui long nhap lai: ");
            //        kiemtra = Int32.TryParse(Console.ReadLine(), out a);
            //    }
            //    kiemtra = false;
            //    while (!kiemtra)
            //    {
            //        Console.Write("Nhap b: ");
            //        kiemtra = Int32.TryParse(Console.ReadLine(), out b);

            //    }
            //    kiemtra = false;
            //    while (!kiemtra)
            //    {
            //        Console.Write("Nhap c: ");
            //        kiemtra = Int32.TryParse(Console.ReadLine(), out c);

            //    }
            //}
            public void nhap()
            {
                bool kiemtra;
                
                do
                {
                    Console.Write("Nhap a: ");
                    kiemtra = Int32.TryParse(Console.ReadLine(), out a);
                } while (!kiemtra);
                while (a == 0)
                {
                    Console.Write("Gia tri a khong duoc bang 0, vui long nhap lai: ");
                    kiemtra = Int32.TryParse(Console.ReadLine(), out a);
                }
                    do
                    {
                    Console.Write("Nhap b: ");
                    kiemtra = Int32.TryParse(Console.ReadLine(), out b);
                } while (!kiemtra);
               
                do
                {
                    Console.Write("Nhap c: ");
                    kiemtra = Int32.TryParse(Console.ReadLine(), out c);
                } while (!kiemtra);
            }
           public void Xuat()
            {
                if (a != 0 && b != 0)
                    Console.WriteLine("{0}X^2 + {1}X + {2} ", a, b, c);
                else
                if (a == 0 && b == 0 && c == 0)
                    Console.WriteLine("Bang 0");
                else
                if (a == 0)
                    Console.WriteLine("{0}X + {1} ", b, c);
                else
                if (b == 0)
                    Console.WriteLine("{0}X^2 + {1} ", a, c);
            }
            public static Tamthuc operator +(Tamthuc tt1, Tamthuc tt2)
            {
                int a = tt1.a + tt2.a;
                int b = tt1.b + tt2.b;
                int c = tt1.c + tt2.c;

                return new Tamthuc(a, b, c);
            }
            public static Tamthuc operator -(Tamthuc tt1, Tamthuc tt2)
            {
                int a = tt1.a - tt2.a;
                int b = tt1.b - tt2.b;
                int c = tt1.c - tt2.c;

                return new Tamthuc(a, b, c);
            }
            public static implicit operator Tamthuc(int number)  //ep kieu ngam dinh chuyen 456 thanh a b c
            {
                int a = number / 100;  //534 chia 100 lay so nguyen cua 5,34 la 5
                int b = (number % 100) / 10; //lay 534 chia lay phan du"number % 100 la 34, lay 34 chia cho 10 lay phan nguyen;
                int c = number % 10; //534 chia cho 10 lay phan du la 53,4 lay phan du la 4

                return new Tamthuc(a, b, c);
            }
            public static explicit operator bool(Tamthuc T)
            {

              
                return ((T.b * T.b - 4 * T.a * T.c) >= 0);

            }

            public static bool operator ==(Tamthuc T1, Tamthuc T2)
            {
                return (T1.a == T2.a && T1.b == T2.b && T1.c == T2.c);
            }
            public static bool operator !=(Tamthuc T1, Tamthuc T2)
            {
                return !(T1 == T2);
            }
            public string GiaiPhuongTrinh()
            {
                string kq = "";
                
                
                if (a == 0 && b == 0 && c == 0)
                { kq = "Phuong trinh vo so nghiem !!"; }
                else
               if (a == 0 && c == 0)
                    kq = "Phuong trinh vo nghiem !!";
                else
               if (a == 0)
                    kq = "PT co 1 nghiem x = " + (-c / b);
                else
                {
                    double delta;
                    delta = b * b - 4 * a * c;
                    if (delta < 0)
                        kq = "Phuong trinh vo nghiem!";
                    else
                        if (delta == 0)
                        kq = "PT co nghiem kep x1 = x2 = " + ((-b) / (2 * a));
                    else
                        kq = "PT co 2 nghiem pb: X1 = " + (((-b) - Math.Sqrt(delta)) / (2 * a)) + "    X2 = " + (((-b) + Math.Sqrt(delta)) / (2 * a));
                };


                return kq;
                


            }
            
          }
        
        static void Main(string[] args)
        {
            Tamthuc ob1 = new Tamthuc();//nhap tam thuc thu nhat
            Console.WriteLine("Tam thuc 1 : ");
            ob1.nhap();
            ob1.Xuat();

            Console.WriteLine("-------------------------------------------");
            Tamthuc ob2 = new Tamthuc();//nhap tam thuc thu hai
            Console.WriteLine("Tam thuc 2 : ");
            ob2.nhap();
            ob2.Xuat();

            Console.WriteLine("--------------------------------------------");
            Tamthuc ob3 = new Tamthuc();
            ob3 = ob1 + ob2;  //tong hai tam thuc
            Console.Write("Tong hai tam thuc: ");
            ob3.Xuat();

            Console.WriteLine();
            ob3 = ob1 - ob2;  //hieu hai tam thuc
            Console.Write("Hieu hai tam thuc: ");
            ob3.Xuat();

            Console.WriteLine();
            Console.Write("Tong tam thuc 1 voi 456: ");
            ob3 = ob1 + 456;
            ob3.Xuat();

            Console.WriteLine();
            Console.Write("KT tam thuc co nghiem ko: ");
            if ((bool)ob1)
                Console.WriteLine("Tam thuc co nghiem ");
            else
                Console.WriteLine("Tam thuc khong co nghiem ");

            Console.WriteLine();
            //tinh nghiem tam thuc
            Console.WriteLine(ob1.GiaiPhuongTrinh());


            Console.WriteLine();
            //so sanh bang ss khac
            if (ob1 == ob2)
                Console.WriteLine("Tam thuc ob1 bang ob2");
            else
                Console.WriteLine("Tam thuc ob1 khong bang ob2");
        }
    }
}

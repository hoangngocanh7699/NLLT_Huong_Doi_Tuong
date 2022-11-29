using System;

namespace baitap
{

    class Program
    {
        public class MaTran
        {
            int h;
            int c;
            double[,] M;
            public MaTran()
            {
                h = 0;
                c = 0;
            }
            public MaTran(int h, int c)
            {
                this.h = h;
                this.c = c;
            }
            public MaTran(int num)
            {
                h = num;
                c = num;
                M = new double[h, c];
            }
            public void NhapMaTran()
            {
                int i, j;
                bool kt;
                do
                {
                    Console.Write("Nhap vao so hang ");
                    kt = Int32.TryParse(Console.ReadLine(), out h);
                    Console.Write("Nhap vao so cot  ");
                    kt = Int32.TryParse(Console.ReadLine(), out c);
                } while (!kt);
                M = new double[h, c];
                double temp = 0;
                for (i = 0; i < h; i++)
                {
                    for (j = 0; j < c; j++)
                    {
                        do
                        {
                            Console.Write("Nhap gia tri mang [{0},{1}]  ", i, j);
                            kt = double.TryParse(Console.ReadLine(), out temp);
                        } while (!kt);
                        M[i, j] = temp;
                    }
                    Console.WriteLine();
                }
            }
            public void XuatMaTran()
            {
                //Console.WriteLine("Mang vua nhap ");
                int i, j;
                for (i = 0; i < h; i++)
                {
                    for (j = 0; j < c; j++)
                    {
                        Console.Write(M[i, j] + " ");
                    }
                    Console.WriteLine();
                }
            }
            /*public static MaTran operator +(MaTran t1, MaTran t2)
            {
                //kiem tra T.h,c !=T2.h,c
                if ((t1.h == t2.h) && (t1.c == t2.c))
                {
                    MaTran t3 = new MaTran(t1.h, t1.c);
                    int i, j;
                    for (i = 0; i < t1.h; i++)
                    {
                        for (j = 0; j < t1.c; j++)
                        {
                            t3.M[i, j] = t1.M[i, j] + t2.M[i, j];
                        }
                    }
                    return t3;
                }
                else
                {
                    Console.WriteLine("loi");
                    return new MaTran(0);
                }

            }*/
            public static MaTran operator +(MaTran x, MaTran y)
            {
                MaTran z = new mmatr (x.h, y.c);
                z.chek(x, y);
                for (int i = 0; i < z.h; i++)
                {
                    for (int j = 0; j < z.c; j++)
                    {

                        z.M[i, j] = x.M[i, j] + y.M[i, j];

                    }
                }
                return z;
            }

            public static MaTran operator -(MaTran t1, MaTran t2)
            {
                //kiem tra T.h,c !=T2.h,c
                if ((t1.h == t2.h) && (t1.c == t2.c))
                {
                    MaTran t3 = new MaTran(t1.h, t1.c);
                    int i, j;
                    for (i = 0; i < t1.h; i++)
                    {
                        for (j = 0; j < t1.c; j++)
                        {
                            t3.M[i, j] = t1.M[i, j] - t2.M[i, j];
                        }
                    }
                    return t3;
                }
                else
                {
                    Console.WriteLine("loi");
                    return new MaTran(0);
                }
            }
            public static MaTran operator *(MaTran t1, MaTran t2)
            {
                int i, j;
                int k;
                double sum;
                if ((t1.h == t2.h) && (t1.c == t2.c))//ktra dk nhan ma tran
                {
                    MaTran matrantich = new MaTran(t1.h, t2.c);

                    for (i = 0; i < t1.h; i++)
                    {
                        for (j = 0; j < t2.c; j++)
                        {
                            sum = 0;
                            for (k = 0; k < t1.c; k++)
                                sum = sum + t1.M[i, k] * t2.M[k, j];
                            matrantich.M[i, j] = sum;
                        }
                    }
                    return matrantich;
                }
                else
                {
                    Console.WriteLine("loi");
                    return new MaTran(0);
                }
            }
           /* public static MaTran operator ==(MaTran t1, MaTran t2)
            {
                //kiem tra T.h,c !=T2.h,c
                if ((t1.h == t2.h) && (t1.c == t2.c))
                {
                    
                    int i, j;
                    for (i = 0; i < t1.h; i++)
                    {
                        for (j = 0; j < t1.c; j++)
                        {
                            return (t1.M[i, j] == t2.M[i, j]);
                        }
                    }
                    
                }
                else
                {
                    Console.WriteLine("loi");
                    return new MaTran(0);
                }
            }

            public static bool operator !=(MaTran t1, MaTran t2)
            {
              
            }
            public MaTran Cheo()
            {
                int i, j, sum = 0, n;
                int[,] arr1 = new int[50, 50];

                Console.Write("\nTinh tong cac phan tu tren duong cheo chinh cua ma tran trong C#:\n");
               

                Console.Write("Nhap kich co ma tran vuong: ");
                n = Convert.ToInt32(Console.ReadLine());
                Console.Write("Nhap cac phan tu cua ma tran:\n");
                for (i = 0; i < n; i++)
                {
                    for (j = 0; j < n; j++)
                    {
                        Console.Write("Phan tu - [{0}],[{1}]: ", i, j);
                        arr1[i, j] = Convert.ToInt32(Console.ReadLine());
                        //tinh tong cac phan tu tren duong cheo chinh
                        if (i == j) sum = sum + arr1[i, j];
                    }
                }

                Console.Write("In ma tran:\n");
                for (i = 0; i < n; i++)
                {
                    for (j = 0; j < n; j++)
                        Console.Write("{0} ", arr1[i, j]);
                    Console.Write("\n");
                }

                Console.Write("Tong cac phan tu tren duong cheo chinh la: {0}\n", sum);

                Console.ReadKey();
                
            }*/
  
    
            public static MaTran ChuyenViMaTran(MaTran a)//chuyen doi vi tri: hang thanh cot, cot thanh hang
            {
                MaTran MaTranChuyenVi = new MaTran(a.c, a.h);
                for (int i = 0; i < a.h; i++)
                {
                    for (int j = 0; j < a.c; j++)
                    {
                        MaTranChuyenVi.M[i, j] = a.M[j, i];
                    }
                }
                return MaTranChuyenVi;
            }
        }
        static void Main(string[] args)
        {
            MaTran mt1 = new MaTran(0);
            MaTran mt2 = new MaTran(0);
            MaTran mt3 = new MaTran(0);
            Console.WriteLine("Nhap mang thu nhat: ");
            mt1.NhapMaTran();
            Console.WriteLine("--------------------------");
            mt1.XuatMaTran();
            Console.WriteLine("--------------------------");
            Console.WriteLine("Nhap mang thu hai: ");
            mt2.NhapMaTran();
            Console.WriteLine("--------------------------");
            mt2.XuatMaTran();

            /*Console.WriteLine("Tong 2 mang: ");
            mt3 = mt1 + mt2;
            mt3.XuatMaTran();
            //chuyen vi ma tran*/
            Console.WriteLine("Chuyen vi ma tran 1");
            MaTran.ChuyenViMaTran(mt1);
        }
    }
}

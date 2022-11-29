using System;

namespace program
{
    class Program
    {
        static void Main(string[] args)
        {
            NameSpaceHinhTron.HinhTron S = new NameSpaceHinhTron.HinhTron();
            S.DienTich();
            NameSpaceHinhcau.HinhCau V = new NameSpaceHinhcau.HinhCau();
            V.DienTich();




            Console.WriteLine("Nhan phim bat ki de thoat...");
            Console.ReadKey();
        }
    }
}

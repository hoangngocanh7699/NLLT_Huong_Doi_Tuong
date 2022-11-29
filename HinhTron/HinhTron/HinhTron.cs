using System;
using System.Collections.Generic;
using System.Text;

namespace NameSpaceHinhTron
{
    class HinhTron
    {
        protected int bk;
        protected double S;
        public HinhTron()
        {
            bk = 0;
        }
        public void DienTich()
        {
            Console.WriteLine("Nhap R: ");
            Int32.TryParse(Console.ReadLine(), out bk);
            double PI = 3.14;
            S = PI * bk * bk;
            Console.WriteLine("Dien Tich hinh tron: {0}", S);

        }
    }
}

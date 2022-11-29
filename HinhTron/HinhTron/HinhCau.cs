using System;
using System.Collections.Generic;
using System.Text;

namespace NameSpaceHinhcau
{
    class HinhCau :NameSpaceHinhTron.HinhTron
    {
        double V;
        public new void DienTich()
        {
            base.DienTich();
            //Console.WriteLine("Nhap R: ");
            //Int32.TryParse(Console.ReadLine(), out bk);
            double PI = 3.14;
            S= 4 * PI * bk * bk;
            Console.WriteLine("Dien Tich Hinh Cau: {0}",S);
            V = 4 / 3 * PI * bk * bk;
            Console.WriteLine("The tich Hinh Cau: {0}", V);
        }
    }
}

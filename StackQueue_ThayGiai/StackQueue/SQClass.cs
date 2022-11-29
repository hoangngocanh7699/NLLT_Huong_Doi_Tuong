using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameSpaceStackQueue
{
    class SQClass
    {
        protected int[] mang;
        protected int n = 0;

                public SQClass()
        {
            Console.WriteLine("Nhap so phan tu mang: ");
            n = int.Parse(Console.ReadLine());
            mang = new int[n];
                     
        }
    }
}

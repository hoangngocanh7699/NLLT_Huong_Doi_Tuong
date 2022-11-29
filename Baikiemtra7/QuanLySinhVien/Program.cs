using System;
using System.IO;

namespace QuanLySinhVien
{
    interface IODatabase
    {
        void Read(string FileName);
        void Write(string FileName);

    }
    interface BaoMat
    {
        void MaHoa();
        void GiaiMa();
    }

    class sinhvien
    {
        protected string _Ho, _Ten, _MSSV;
        public sinhvien()
        { }
        public sinhvien(string Ho, string Ten, string MSSV)
        {
            _Ho = Ho;
            _Ten = Ten;
            _MSSV = MSSV;
        }
        public string Ho
        {
            get { return _Ho; }
            set { _Ho = value; }
        }
        public string Ten
        {
            get { return _Ten; }
            set { _Ten = value; }
        }
        public string MSSV
        {
            get { return _MSSV; }
            set { _MSSV = value; }
        }
        public string HoTen
        {
            get { return _Ho + " " + _Ten; }
        }
    }
    class lophoc : IODatabase,BaoMat
    {
        protected sinhvien[] mang;
        protected int _siso, _max;
        public lophoc()
        {
            _max = 100;
            _siso = 0;
            mang = new sinhvien[_max];
        }
        public int siso
        {
            get { return _siso; }
        }
        public void them1sv()
        {
            Console.Write("Nhap Ho: ");
            string Ho = Console.ReadLine();
            Console.Write("Nhap Ten: ");
            string Ten = Console.ReadLine();
            Console.Write("Nhap MSSV: ");
            string MSSV = Console.ReadLine();
            var sv = new sinhvien(Ho, Ten, MSSV);
            mang[_siso] = sv;
            _siso++;
        }
        public void xuat()
        {
            for (int i = 0; i < _siso; i++)
            {
                Console.WriteLine("Sinh vien thu {0}", i + 1);
                Console.WriteLine("MSSV: {0} Ho va Ten: {1}", mang[i].MSSV, mang[i].HoTen);
            }
        }
        public void timtheoten(string ten)
        {
            int dem = 0;
            for (int i = 0; i < _siso; i++)
            {
                if (ten == mang[i].Ten)
                {
                    Console.WriteLine("MSSV: {0} Ho va Ten: {1}", mang[i].MSSV, mang[i].HoTen);
                    dem++;
                }
            }
            if (dem == 0)
            {
                Console.WriteLine("Khong tim thay!");
            }
        }
        public void timtheoms(string mssv)
        {
            int dem = 0;
            for (int i = 0; i < _siso; i++)
            {
                if (mssv == mang[i].MSSV)
                {
                    Console.WriteLine("MSSV: {0} Ho va Ten: {1}", mang[i].MSSV, mang[i].HoTen);
                    dem++;
                }
            }
            if (dem == 0)
            {
                Console.WriteLine("Khong tim thay!");
            }
        }
        public void xoa(string mssv)
        {
            for (int i = 0; i < _siso; i++)
            {
                if (mssv == mang[i].MSSV)
                {
                    while (i < _siso)
                    {
                        mang[i].MSSV = mang[i + 1].MSSV;
                        mang[i].Ho = mang[i + 1].Ho;
                        mang[i].Ten = mang[i + 1].Ten;
                        _siso--;
                    }

                }
            }
        }
        public void Write(string filename)
        {
            FileStream file;
            file = new FileStream(filename, FileMode.OpenOrCreate);
            StreamWriter sw = new StreamWriter(file);
            sw.WriteLine(_siso);
            for (int i = 0; i < _siso; i++)
            {
                sw.WriteLine(mang[i].MSSV);
                sw.WriteLine(mang[i].Ho);
                sw.WriteLine(mang[i].Ten);
            }
            sw.Close();
            file.Close();
        }
        public void Read(string filename)
        {
            FileStream file;
            file = new FileStream(filename, FileMode.Open);
            StreamReader sr = new StreamReader(file);
            string siso = sr.ReadLine();

            _siso = Int32.Parse(siso);
            mang = new sinhvien[_siso];

            for (int i = 0; i < _siso; i++)
            {

                string Ho = sr.ReadLine();
                string Ten = sr.ReadLine();
                string MSSV = sr.ReadLine();
                var sv = new sinhvien(Ho, Ten, MSSV);
                mang[i] = sv;
            }
            sr.Close();
            file.Close();
            //public void MaHoa()
            //{
            //    string KQ = "";
            //    for (int i = 0; i < mang.Length; i++)
            //    {
            //        KQ = KQ + (char)((int)mang[i] + 5);
            //        mang = KQ;
            //    }
            //}
            //public void GiaiMa()
            //{
            //    string KQ = "";
            //    for (int i = 0; i < mang.Length; i++)
            //    {
            //        KQ = KQ + (char)((int)mang[i] - 5);
            //        mang = KQ;
            //    }
            //}
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            string filename = "c:\\DATA\\abc.txt";
            int ss;
            string ten, mssv, xoa;
            lophoc ctk42 = new lophoc();
            ctk42.Read(filename);
            ctk42.xuat();
            Console.ReadLine();

            Console.Write("Nhap si so lop: ");
            ss = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap thong tin sinh vien");
            for (int i = 0; i < ss; i++)
            {
                Console.WriteLine("Sinh vien thu {0}", i + 1);
                ctk42.them1sv();
            }
            ctk42.xuat();

            ctk42.Write(filename);

            Console.Write("Nhap Ten can tim: ");
            ten = Console.ReadLine();
            ctk42.timtheoten(ten);

            Console.Write("Nhap MSSV can tim: ");
            mssv = Console.ReadLine();
            ctk42.timtheoms(mssv);

            Console.Write("Nhap MSSV can Xoa: ");
            xoa = Console.ReadLine();
            ctk42.xoa(xoa);

            ctk42.xuat();
            Console.ReadLine();


        }
    }
}
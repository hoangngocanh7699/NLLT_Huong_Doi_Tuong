using System;

namespace Bai1
{
    class Program
    {
        class Phanso
        {
            int tuso, mauso;
            public Phanso(Phanso ob)
            {
                tuso = ob.tuso;
                mauso = ob.mauso;
            }
            public Phanso(int x,int y)
            {
                tuso = x;
                mauso = y;
            }
    public int Age { get; set; }

    public string Name { get; set; }
            public void show()
            {
                Console.WriteLine("Phanso:{0}/{1}", tuso, mauso);
            }
        }
        static void Main(string[] args)
        {
            Phanso ob1=new Phanso(2,5);
            ob1.show();
            Phanso ob2 = new Phanso(ob1);
            ob2.show();
            Console.ReadLine();
        }
    }
}

using System;

namespace Bai5
{
    
        public class Time
        {
            private int Hour;
            private int Minute;
            private int Second;
            public void Display()
            {
                Console.WriteLine("Gio hien tai: {0} Gio {1} Phut {2} Giay", Hour, Minute, Second);
            }
            public void GetTime(ref int h,ref int m,ref int s)
            {
                h = Hour;
                m = Minute;
                s = Second;
            }
            public Time(System.DateTime dt)
            {
                Hour = dt.Hour;
                Minute = dt.Minute;
                Second = dt.Second;
            }
        }
        public class PassingParameterByRef
        {
            static void Main()
            {
            DateTime currentTime = DateTime.Now;
            Time t = new Time(currentTime);
            t.Display();

            int theHour = 0;
            int theMinute = 0;
            int theSecond = 0;
            t.GetTime(ref theHour, ref theMinute, ref theSecond);
            Console.WriteLine("Current Time: {0}, {1}, {2}",theHour,theMinute,theSecond);
            Console.ReadLine();
            }
        }
        
    
}

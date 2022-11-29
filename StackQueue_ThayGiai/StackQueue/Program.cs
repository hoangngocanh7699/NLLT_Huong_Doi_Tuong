using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            NameSpaceStack.StackClass S = new NameSpaceStack.StackClass();

            for(int i=0; i<10; i++)
                  S.Push(i+1);

            Console.WriteLine(" Cac gia tri trong Stack" );
            for (int i = 0; i < 10; i++)
                Console .Write (" {0} ", S.Pop());

    */

            NameSpaceQueue.QueueClass Q = new NameSpaceQueue.QueueClass();

            for (int i = 0; i < 10; i++)
                Q.Push(i + 1);

            Console.WriteLine(" Cac gia tri trong Queue");
            for (int i = 0; i < 10; i++)
                Console.Write(" {0} ", Q.Pop());






        }
    }
}


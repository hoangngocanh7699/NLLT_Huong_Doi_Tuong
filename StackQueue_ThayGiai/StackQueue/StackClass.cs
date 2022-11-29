using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameSpaceStack
{
    
        class StackClass : NameSpaceStackQueue.SQClass
        {
        int top;
            public StackClass():base()
            {
                top = 0;
            }
            public bool IsEmpty()
            {
                return top == 0;
            }
            public bool IsFull()
            {
                return (top == n);
            }
            public void Push(int item)
            {
                if (IsFull())
                {
                    Console.WriteLine("Mang da day!");
                }
                else
                {
                    mang[top] = item;
                    top++;
                }
            }
            public int Pop()
            {
                if (IsEmpty())
                {
                    Console.WriteLine("Stack dang rong!");
                    return -1;
                }
                else
                {
                    top--;
                    return mang[top];
                }
            }
           
        }


       
}

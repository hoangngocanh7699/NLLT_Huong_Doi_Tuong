using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameSpaceQueue
{
    class QueueClass: NameSpaceStackQueue.SQClass
    {
            int front;
            int rear;
            public  bool empty()
            {
            if (front == rear)
                return true;
            else
                return false;


             }
            public QueueClass(): base ()

            {
                rear = 0;
                front = 0;

            }
            public bool full()
            {
            if (rear == n)
                return true;
            else
                return false;
            
                        
            }
            //enqueue: thêm 1 phần tử vào hàng đợi.
            public void Push(int item)
            {
                if (full())
                {
                    Console.WriteLine("hang doi full");
                    return;
                }
                
                mang[rear] = item;
                rear++;
        }
            //dequeue(): xóa 1 phần tử khỏi hàng đợi.
            public int Pop()
            {
                if (empty())
                {
                    Console.WriteLine("hang doi rong");
                    return -1;
                }
            //mang[front] = 0;
            int temp= mang[front];
            front++;
            return temp;
            }
            

    
    }

}

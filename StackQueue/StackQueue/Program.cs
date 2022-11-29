using System;

namespace StackQueue
{
    public class StackQueue
    {
        protected int size;
        protected int length;
        protected int [] array;
        
    }
    class Stack:StackQueue
    {
        public Stack()
        {
            size = 100;
            array = new int[size];
            length = 0;
          
        }
        public Stack(int size)
        {
            this.size = size;
            array = new int[size];
            length = 0;
            
        }
        public void Reset()
        {
            length = 0;
        }
        public bool IsFull()
        {
            return length == size;
        }
        public bool IsEmpty()
        {
            return length == 0;
        }
        public void Push(int number)
        {
            if (IsFull())
            {
                Console.WriteLine("Stack day! khong the them");
                return;
            }
            
            array[length] = number;
            length = length + 1;
        }
        public int Pop()
        {
            if (IsEmpty())
                throw new InvalidOperationException("Stack trong! Khong the tra ve phan tu ");
            
            int number = array[length - 1];
            length = length - 1;
            return number;
        }
    }
    class Queue : Stack
    {
        int front;
        int rear;
        public new bool IsEmpty()
        {
            return (front < 0 || front > rear) ? true : false;
        }
        public Queue():base()

        {
            
            rear = 0;
            front = 0;

        }
        public bool IsFull()
        {
            if (rear == size)
                return true;
            else
                return false;
        }
        //enqueue: thêm 1 phần tử vào hàng đợi.
        public void enqueue(int item)
        {
            if (IsFull())
            {
                Console.WriteLine("hang doi full");
                return;
            }
            
            array[rear] = item;
            rear++;
        }
        
        public int dequeue()
        {
            if (IsEmpty())
            {
                Console.WriteLine("hang doi rong");
                return -1;
            }
            int temp = array[front];
            front++;
            return temp;
        }
        //peek(): lấy phần tử đầu của hàng đợi mà không xóa nó.
        public int peek()
        {
            return array[front];
        }

    }

class Program
    {
        static void Main(string[] args)
        {
            Stack S = new Stack(10);
            for (int i = 0; i < 10; i++)
                S.Push(i);
            Console.WriteLine("Stack ");
            for (int i = 0; i < 10; i++)
            {
                int number = S.Pop();
                Console.WriteLine("{0}", number);

            }
            Queue Q = new Queue();
            for (int i = 0; i < 10; i++)
                Q.enqueue(i);
            Console.WriteLine("Queue ");
            for (int i = 0; i < 10; i++)
            {
                
                Console.WriteLine("{0}", Q.dequeue());
            }
            Console.ReadKey();
        }
    }
}

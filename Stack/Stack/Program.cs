using System;

namespace Stack
{
    class Program
    {
        public class Stack
        {
            int[] stack;
            int top;
        public static bool Isfull(Stack S) //Kiểm tra stack đầy(IsFull)
        {
            if (S.top >= S.stack.Length - 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
            public static bool IsEmpty(Stack S) //Kiểm tra stack rỗng(IsEmpty)
            {
                if (S.top == -1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        public static void Push(Stack S, int x) //đẩy phần tử vào stack
        {
            if (Isfull(S) == false)            //kiểm tra stack có đầy hay không
            {
                S.top++;                       //tăng top lên 1
                S.stack[S.top] = x;             //gán x vào vị trí top
            }
            else
            {
                Console.WriteLine("Stack Overflow (Tràn ngăn xếp)");
            }

        }
        public static void Pop(Stack S)         //lấy phần tử
        {
            if (IsEmpty(S) == false)            //kiểm tra stack có trống hay không?
            {
                S.top--;                        //giảm top đi 1
            }
            else
            {
                Console.WriteLine("Stack Underflow");
            }
        }
        public static void Peek(Stack S)        //lấy giá trị top
        {
            if (IsEmpty(S) == false)            //kiểm tra stack có trống hay không
            {
                Console.WriteLine("Top Element: " + S.stack[S.top]);
            }
            else
            {
                Console.WriteLine("Stack Underflow");
            }
        }
        public static void NumberElement(Stack S)//xuất các phần tử có trong stack
        {
            string str = " ";
            for (int i = S.top; i >= 0; i--)     //gán i từ top đến 0
            {
                str += S.stack[i] + " ";
            }
            Console.WriteLine("Element: " + str);
        }
            void nhap()
            {
                Console.WriteLine("Input Number: ");
                int x = int.Parse(Console.ReadLine(), out );
            }
        }
        static void Main(string[] args)
            {
            Stack S = new Stack();
            
            
        }
        }
    }

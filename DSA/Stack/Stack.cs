using System;
using System.Collections.Generic;
using System.Text;

namespace DSA.Stack
{
    public class Stack
    {
        public static void run()
        {
            Stack<int> st = new Stack<int>();
            st.Push(19);
            st.Push(20);
            st.Push(30);
            st.Push(1923);
            Console.WriteLine(st.Peek());
            Console.ReadLine();
        }

        /*
            arr[] = {1,4,5,3,66,3,2,4} 
        output
        1->4
        4->5
        5->66
        3->66
        66->-1
        3->4
        2->4
        4->-1
        */
        public static void NextGreateValue(int[] values)
        {
            Stack<int> s1 = new Stack<int>();
            s1.Push(values[values.Length - 1]);
            for (int i = values.Length - 2; i >= 0; i--)
            {
                while (s1.Count > 0 && s1.Peek() < values[i])
                {
                    s1.Pop();
                }
                if (s1.Count == 0)
                {
                    s1.Push(-1);
                }
                else
                {
                    s1.Push(values[i]);
                }
            }
        }
    }

    public class SpecialStack : Stack<int>
    {
        Stack<int> min = new Stack<int>();
        public new void Push(int val)
        {
            if (base.Count > 0)
            {
                int tempVal = min.Peek();
                if (tempVal < val)
                {
                    min.Push(tempVal);
                }
                else
                {
                    min.Push(val);
                }
            }
            else
            {
                min.Push(val);
            }
            base.Push(val);
        }

        public new int Pop()
        {
            int val = base.Pop();
            min.Pop();
            return val;
        }

        public int GetMin()
        {
            return min.Peek();
        }
    }

    public class QueueFromStack
    {
        public static Stack<int> s1 = new Stack<int>();
        public static Stack<int> s2 = new Stack<int>();


        public static void EnQueue(int x)
        {
            while (s1.Count > 0)
            {
                s2.Push(s1.Pop());
            }
            s1.Push(x);
            while (s2.Count > 0)
            {
                s1.Push(s2.Pop());
            }
        }

        public static int DeQueue()
        {
            if (s1.Count == 0)
            {
                Console.WriteLine("no data found");
                return -1;
            }
            else
            {
                int x = (int)s1.Peek();
                s1.Pop();
                return x;
            }
        }
    }

    public class StackFromQueue
    {
        public static Queue<int> q1 = new Queue<int>();
        public static Queue<int> q2 = new Queue<int>();


        public static void Push(int x)
        {
            while (q1.Count > 0)
            {
                q2.Enqueue(q1.Peek());
                q1.Dequeue();
            }
        }

        //public static int DeQueue()
        //{
        //    if (s1.Count == 0)
        //    {
        //        Console.WriteLine("no data found");
        //        return -1;
        //    }
        //    else
        //    {
        //        int x = (int)s1.Peek();
        //        s1.Pop();
        //        return x;
        //    }
        //}
    }


}

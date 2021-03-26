using System;
using System.Collections.Generic;
using System.Text;

namespace DSA.Stack
{
    public class BraketMatcher
    {
        public static Stack<char> st = new Stack<char>();

        public static bool Check(string str)
        {
            int count = 0;
            
            foreach (var item in str)
            {
                bool flag = true;
                if (item == ')')
                {
                    count = 0;
                    while (flag)
                    {
                        if (st.Peek() == '(') flag = false;
                        count++;
                        st.Pop();
                    }
                }
                else
                {
                    st.Push(item);
                }
                if (count == 1)
                {
                    return false;
                }
            }
            return true;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Stack
{
    class Stack
    {
        private string[] stack;
        private int count = 0;





        public int Count
        {
            get { return count; }
        }

        public string this[int i]
        {
            get { return stack[i]; }
            set { stack[i] = value; }
        }

        public Stack() {
            stack = new string[10]; 
        }

        public Stack(int size)
        {
            stack = new string[size];
        }

        public void Push(string value)
        {
            if (stack.Length == count)
                ReSize((int)(count * 2));
            stack[count] = value;
            count++;
        }

        public string Pop()
        {
            count--;
            if (count == stack.Length / 2 && stack.Length > 100)
                ReSize((int)(count * 0.3));

            return stack[count];
        }

        private void ReSize(int size)
        {
            string[] temp = stack;

            stack = new string[size];

            for (int i = 0; i < count; i++)
            {
                stack[i] = temp[i];
            }
        }

        public void Clear()
        {
            count = 0;
            stack = new string[10];
        }

    }
}

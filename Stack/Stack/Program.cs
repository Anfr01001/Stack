using System;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Stack stack = new Stack();

            string s = "Hej jagg< hetaaa<<<erasdf<<< inget";

            for (int i = 0; i < s.Length; i++)
            {
                if(s[i] == '<')
                {
                    stack.Pop();
                }
                else
                {
                    stack.Push(s[i].ToString());
                }

            }

            for (int i = 0; i < stack.Count; i++)
            {
                Console.Write(stack[i]);
            }
            Console.ReadLine();

        }
    }
}

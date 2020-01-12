using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeedCodeCs
{
    class Solution_155
    {
        public class MinStack
        {
            private Stack<int> minStack;
            private Stack<int> stack;

            /** initialize your data structure here. */
            public MinStack()
            {
                this.minStack = new Stack<int>();
                this.stack = new Stack<int>();
            }

            public void Push(int x)
            {
                this.stack.Push(x);
                if (this.minStack.Count == 0 || this.minStack.Peek() > x)
                {
                    this.minStack.Push(x);
                }
                else
                {
                    this.minStack.Push(this.minStack.Peek());
                }

            }

            public void Pop()
            {
                this.minStack.Pop();
                this.stack.Pop();
            }

            public int Top()
            {
                return this.stack.Peek();
            }

            public int GetMin()
            {
                return this.minStack.Peek();
            }
        }
    }
}

using System;

namespace DSImplementation.Stack.Implementation.LinkedList
{
    public class MyStack<T>
    {
        private class StackNode {
            public T Data { get; set; }
            public StackNode Next { get; set; }
        }

        private StackNode _top;

        public void Push(T item)
        {
            StackNode newNode = new StackNode();
            newNode.Data = item;
            newNode.Next = null;

            if (_top == null)
            {
                _top = newNode;
            }
            else
            {
                newNode.Next = _top;
                _top = newNode;
            }
        }

        public T Pop()
        {
            if (_top == null)
            {
                throw new InvalidOperationException("Stack is empty.");
            }

            T data = _top.Data;
            _top = _top.Next;

            return data;
        }

        public T Peek()
        {
            return _top.Data;
        }

        public bool IsStackEmpty()
        {
            return (_top == null);
        }
    }
}

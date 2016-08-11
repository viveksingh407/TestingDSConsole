using System;
using DSImplementation.LinkedList.Implementation;

namespace DSImplementation.Stack.Implementation.LinkedList
{
    public class MyStack<T>
    {
        private class StackNode {
            public T Data { get; set; }
            public StackNode Next { get; set; }
        }

        private LinkedList<T> list;

        private LinkedListNode<T> _top;

        public void Push(T item)
        {
            if(list == null)
                list = new LinkedList<T>();

            list.InsertFirstNode(item);

            _top = list.GetHeaderNode();

            //StackNode newNode = new StackNode();
            //newNode.Data = item;
            //newNode.Next = null;

            //if (_top == null)
            //{
            //    _top = newNode;
            //}
            //else
            //{
            //    newNode.Next = _top;
            //    _top = newNode;
            //}
        }

        public T Pop()
        {
            if (list == null)
                list = new LinkedList<T>();

            var data = list.DeleteFirstNode();
            _top = list.GetHeaderNode();

            //if (_top == null)
            //{
            //    throw new InvalidOperationException("Stack is empty.");
            //}

            //T data = _top.Data;
            //_top = _top.Next;

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

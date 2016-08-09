using System;
using DSImplementation.Tree.Implementation.LinkedList;

namespace DSImplementation.Queue.Implementation.LinkedList
{
    public class MyQueue<T>
    {
        private class QueueNode {
            public T Data { get; set; }
            public QueueNode Next { get; set; }
        }

        private QueueNode Front { get; set; }
        private QueueNode Rear { get; set; }

        public void Enqueue(T item)
        {
            QueueNode temp = new QueueNode();
            temp.Data = item;
            temp.Next = null;

            if (Rear == null)
            {
                Front = temp;
                Rear = temp;
            }
            else {
                Rear.Next = temp;
                Rear = temp;
            }
        }

        public T Dequeue()
        {
            QueueNode temp = new QueueNode();

            if (Front == null)
            {
                throw new InvalidOperationException("Queue is Empty");
            }
            else
            {
                temp = Front;
                Front = Front.Next;

                if(Front == null)
                {
                    Rear = null;
                }
            }

            return temp.Data;
        }

        public T Peek()
        {
            return Front.Data;
        }

        public bool IsQueueEmpty()
        {
            return (Front == null && Rear == null);
        }
    }
}

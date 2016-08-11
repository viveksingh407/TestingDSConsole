using System;
using DSImplementation.LinkedList.Implementation;
using DSImplementation.Tree.Implementation.LinkedList;

namespace DSImplementation.Queue.Implementation.LinkedList
{
    public class MyQueue<T>
    {
        private class QueueNode {
            public T Data { get; set; }
            public QueueNode Next { get; set; }
        }

        private LinkedList<T> list;

        private LinkedListNode<T> Front { get; set; }
        private LinkedListNode<T> Rear { get; set; }

        public void Enqueue(T item)
        {
            if (list == null)
                list = new LinkedList<T>();

            list.InsertLastNode(item);

            Front = list.GetHeaderNode();
            Rear = list.GetLastNode();

            //QueueNode temp = new QueueNode();
            //temp.Data = item;
            //temp.Next = null;

            //if (Rear == null)
            //{
            //    Front = temp;
            //    Rear = temp;
            //}
            //else {
            //    Rear.Next = temp;
            //    Rear = temp;
            //}
        }

        public T Dequeue()
        {
            if (list == null)
                list = new LinkedList<T>();

            var data = list.DeleteFirstNode();

            Front = list.GetHeaderNode();
            Rear = list.GetLastNode();
            
            //QueueNode temp = new QueueNode();

            //if (Front == null)
            //{
            //    throw new InvalidOperationException("Queue is Empty");
            //}
            //else
            //{
            //    temp = Front;
            //    Front = Front.Next;

            //    if(Front == null)
            //    {
            //        Rear = null;
            //    }
            //}

            return data;
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

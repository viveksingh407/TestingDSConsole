using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSImplementation.Queue.Implementation.Array
{
    public class MyQueue<T>
    {
        private T[] _item;
        private int _front = 0;
        private int _rear = 0;

        private static bool _isPrint = false;

        public MyQueue(int capacity, bool isPrint)
        {
            _item = Utility.InitializeGenericArray<T>(capacity);
            _isPrint = isPrint;
        }

        public T Peek()
        {
            return _item[_front];
        }

        public void Enqueue(T item)
        {
            if (_rear > _item.Length - 1)
            {
                throw new InvalidOperationException("Queue is full.");
            }

            _item[_rear] = item;
            _rear += 1;

            if (_isPrint)
            {
                Utility.PrintFilteredGenericArray<T>(_item);
            }
        }

        public T Dequeue()
        {
            var item = default(T);

            if (_rear == 0 || _front >= _rear)
            {
                throw new InvalidOperationException("Queue is empty.");
            }

            item = _item[_front];
            _item[_front] = default(T);
            _front += 1;

            if (_isPrint)
            {
                Utility.PrintFilteredGenericArray<T>(_item);
            }

            return item;
        }

        public bool isStackEmpty()
        {
            return (_rear == 0 || _front >= _rear);
        }
    }
}

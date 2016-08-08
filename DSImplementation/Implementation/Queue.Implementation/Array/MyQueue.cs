using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSImplementation.Queue.Implementation.Array
{
    public class MyQueue
    {
        private int[] _item;
        private int _front = 0;
        private int _rear = 0;

        private static bool _isPrint = false;

        public MyQueue(int capacity, bool isPrint)
        {
            _item = Utility.InitializeArray(capacity);
            _isPrint = isPrint;
        }

        public void Enqueue(int item)
        {
            if (_rear > _item.Length - 1)
            {
                throw new InvalidOperationException("Queue is full.");
            }

            _item[_rear] = item;
            _rear += 1;

            if (_isPrint)
            {
                Utility.PrintFiltered(_item);
            }
        }

        public int Dequeue()
        {
            var item = -999;

            if (_rear == 0 || _front >= _rear)
            {
                throw new InvalidOperationException("Queue is empty.");
            }

            item = _item[_front];
            _item[_front] = -999;
            _front += 1;

            if (_isPrint)
            {
                Utility.PrintFiltered(_item);
            }

            return item;
        }

        public bool isStackEmpty()
        {
            return (_rear == 0 || _front >= _rear);
        }
    }
}

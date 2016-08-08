using System;

namespace DSImplementation.Stack.Implementation.Array
{
    public class MyStack
    {
        private int[] _item;
        private int _currentIndex = 0;

        private static bool _isPrint = false;

        public MyStack(int capacity, bool isPrint)
        {
            _item = Utility.InitializeArray(capacity);
            _isPrint = isPrint;
        }

        public void Push(int item)
        {
            if (_currentIndex <= _item.Length - 1)
            {
                _item[_currentIndex] = item;
                _currentIndex += 1;

                if (_isPrint)
                {
                    Utility.PrintFiltered(_item);
                }
            }
            else
            {
                Console.WriteLine("Stack is full.");
            }
        }

        public int Pop()
        {
            var item = -999;

            if (_currentIndex > 0)
            {
                _currentIndex -= 1;
                item = _item[_currentIndex];
                _item[_currentIndex] = -999;

                if (_isPrint)
                {
                    Utility.PrintFiltered(_item);
                }
            }
            else
            {
                Console.WriteLine("Stack is empty.");
            }

            return item;
        }

        public int Peek()
        {
            var item = -999;

            if (!this.isStackEmpty())
            {
                item = _item[--_currentIndex];
            }
            else
            {
                Console.WriteLine("Stack is empty.");
            }

            return item;
        }

        public bool isStackEmpty()
        {
            return (_currentIndex == 0);
        }
    }
}

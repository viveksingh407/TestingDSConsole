using System;

namespace DSImplementation.Heap.Implementation
{
    public class Heap
    {
        private int _capacity = 0;
        public int _heapSize = 0;
        public int[] _heap;

        public Heap(int capacity)
        {
            _capacity = capacity;
            _heapSize = 0;
            _heap = new int[capacity];
        }

        public int Parent(int i)
        {
            return (i - 1) / 2;
        }

        public void DeleteKey(int i)
        {
            DecreaseKey(i, int.MinValue);
            //Utility.PrintAll("Deleted: ", _heap);
            ExtractMin();
        }

        public void DecreaseKey(int i, int new_val)
        {
            int temp = int.MinValue;
            _heap[i] = int.MinValue;

            int parentIndex = Parent(i);

            while (i != 0 && _heap[parentIndex] > _heap[i])
            {
                temp = _heap[i];
                _heap[i] = _heap[parentIndex];
                _heap[parentIndex] = temp;

                i = parentIndex;
                parentIndex = Parent(i);
            }
        }

        public int ExtractMin()
        {
            if (_heapSize <= 0)
                return int.MaxValue;

            if (_heapSize == 0)
            {
                _heapSize -= 1;
                return _heap[0];
            }

            int root = _heap[0];
            _heap[0] = _heap[_heapSize - 1];
            _heapSize -= 1;
            MinHeapify(0);

            return root;
        }

        public void InsertKey(int k)
        {
            if (_heapSize == _capacity)
            {
                throw new InvalidOperationException("Heap is full");
            }

            int temp = int.MinValue;
            int i = _heapSize;
            _heap[i] = k;

            _heapSize += 1;

            int parentIndex = Parent(i);

            var a = string.Join(", ", _heap);

            while (i != 0 && _heap[parentIndex] > _heap[i])
            {
                temp = _heap[i];
                _heap[i] = _heap[parentIndex];
                _heap[parentIndex] = temp;

                i = parentIndex;
                parentIndex = Parent(i);
            }

            a = string.Join(", ", _heap);
        }

        public void MinHeapify(int i)
        {
            int left = LeftKey(i);
            int right = RightKey(i);
            int smallest = i;
            int temp = int.MinValue;

            if (left < _heapSize && _heap[left] < _heap[i])
            {
                smallest = left;
            }

            if (right < _heapSize && _heap[right] < smallest)
            {
                smallest = right;
            }

            if (smallest != i)
            {
                temp = _heap[i];
                _heap[i] = _heap[smallest];
                _heap[smallest] = temp;

                MinHeapify(smallest);
            }
        }

        public int LeftKey(int i) { return (2 * i + 1); }

        public int RightKey(int i) { return (2 * i + 2); }

        public int GetMin() { return _heap[0]; }
    }
}

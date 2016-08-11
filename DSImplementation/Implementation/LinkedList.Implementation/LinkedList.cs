using System;

namespace DSImplementation.LinkedList.Implementation
{
    public class LinkedListNode<T>
    {
        public T Data { get; set; }
        public LinkedListNode<T> Next { get; set; }
    }
    public class LinkedList<T>
    {
        private LinkedListNode<T> _rootNode { get; set; }

        public void InsertFirstNode(T item)
        {
            LinkedListNode<T> newNode = new LinkedListNode<T>();
            newNode.Data = item;
            newNode.Next = null;

            if (_rootNode != null)
            {
                newNode.Next = _rootNode;
            }

            _rootNode = newNode;
        }

        public void Traverse()
        {
            LinkedListNode<T> temp = _rootNode;

            if (temp == null)
            {
                Console.WriteLine("List is empty");
                return;
            }

            while (temp != null)
            {
                Console.Write(temp.Data + " ");
                temp = temp.Next;
            }

            Console.WriteLine();
        }

        public void InsertLastNode(T item)
        {
            LinkedListNode<T> temp = _rootNode;
            LinkedListNode<T> newNode = new LinkedListNode<T>();
            newNode.Data = item;
            newNode.Next = null;

            if (temp != null)
            {
                while (temp.Next != null)
                {
                    temp = temp.Next;
                }

                temp.Next = newNode;
            }
        }

        public void InsertNthNode(T item, int n)
        {
            LinkedListNode<T> newNode = new LinkedListNode<T>();
            newNode.Data = item;
            newNode.Next = null;

            if (n > 0)
            {
                LinkedListNode<T> node = GetNthNode(n - 1);

                newNode.Next = node.Next;
                node.Next = newNode;
            }
            else if (n == 0)
            {
                newNode.Next = _rootNode;
                _rootNode = newNode;
            }
        }

        public void InsertNthFromLastNode(T item, int n)
        {
            LinkedListNode<T> node = GetNthFromLastNode(n);
            LinkedListNode<T> newNode = new LinkedListNode<T>();
            newNode.Data = item;
            newNode.Next = null;

            if (n > 0)
            {
                newNode.Next = node.Next;
                node.Next = newNode;
            }
        }

        public void DeleteFirstNode()
        {
            if (_rootNode != null)
            {
                _rootNode = _rootNode.Next;
            }
            else
            {
                throw new InvalidCastException("The list is empty.");
            }
        }

        public void DeleteLastNode()
        {
            if (_rootNode != null && _rootNode.Next != null)
            {
                LinkedListNode<T> node = GetNthFromLastNode(2);

                node.Next = null;
            }
            else if (_rootNode.Next == null)
            {
                _rootNode = null;
            }
            else
            {
                throw new InvalidCastException("The list is empty.");
            }
        }

        public void DeleteNthNode(int n)
        {
            if (n > 0)
            {
                LinkedListNode<T> currentNode = GetNthNode(n);
                LinkedListNode<T> parentNode = GetNthNode(n - 1);

                parentNode.Next = currentNode.Next;
                currentNode = null;
            }
            else if (n == 0)
            {
                _rootNode = null;
            }
            else
            {
                throw new InvalidCastException("Please provide positive index.");
            }
        }

        public void DeleteNthFromLastNode(int n)
        {
            LinkedListNode<T> currentNode = GetNthFromLastNode(n);
            LinkedListNode<T> lastNode = GetNthFromLastNode(n + 1);

            if (n > 0)
            {
                lastNode.Next = currentNode.Next;
                currentNode = null;
            }
        }

        private LinkedListNode<T> GetNthNode(int n)
        {
            LinkedListNode<T> temp = _rootNode;

            while(temp != null && n > 1)
            {
                temp = temp.Next;
                n -= 1;
            }

            return temp;
        }

        private LinkedListNode<T> GetNthFromLastNode(int n)
        {
            LinkedListNode<T> temp = _rootNode;
            LinkedListNode<T> counterNode = _rootNode;
            int firstCounter = 1;

            while (temp.Next != null)
            {
                temp = temp.Next;

                if (firstCounter >= n)
                {
                    counterNode = counterNode.Next;
                }

                firstCounter += 1;
            }

            if (firstCounter < n + 1)
            {
                throw new InvalidOperationException("The list is smaller than provided counter.");
            }

            return counterNode;
        }

        public LinkedListNode<T> GetLastNode()
        {
            LinkedListNode<T> temp = _rootNode;

            if (_rootNode != null)
            {
                while (temp.Next != null)
                {
                    temp = temp.Next;
                }

                return temp;
            }
            else
            {
                return _rootNode;
            }
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace UVP_311LinkedList
{
    public class LinkedList<T> : IEnumerable<T>
    {
        public Node<T> Head { get; set; }
        public Node<T> Tail { get; set; }
        public int Size { get; set; }



        public void Add(T data)
        {
            Node<T> node = new Node<T>(data);

            if (Head == null)
            {
                Head = node;
            }
            else
            {
                Tail.Next = node;
            }
            Tail = node;
            Size++;
        }

        public Node<T> GetNode(int index)
        {
            Node<T> current = Head;
            int k = 0;
            while (k < index)
            {
                current = current.Next;
                k++;
            }

            return current;
        }


        public void Remove(int index)
        {
            Node<T> current = Head;
            int k = 0;
            while (k < index - 1)
            {
                current = current.Next;
                k++;
            }
            if (k == 0)
            {
                if (Head.Next != null)
                {
                    Head = Head.Next;
                }
                else
                {
                    Head = null;
                }
            }
            else if (k == Size - 1)
            {
                current.Next = null;
                Tail = null;
            }
            else
            {
                current.Next = current.Next.Next;
            }
            Size--;
        }

        public bool isEmptyList()
        {
            return Size == 0;
        }

        public void doClear()
        {
            Head = null;
            Tail = null;
            Size = 0;
        }
        public void addToHead(T student)
        {
            Node<T> node = new Node<T>(student);
            node.Next = Head;
            Head = node;
            if (Size == 0)
            {
                Tail = Head;
            }
            Size++;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        public IEnumerator<T> GetEnumerator()
        {
            Node<T> current = Head;
            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }

    }

}

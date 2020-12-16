using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace UVP_311LinkedList
{
    public class LinkedList<Student> : IEnumerable
    {
       public Node<Student> head { get; set; }
        public Node<Student> tail { get; set; }
        int numberOfStudents { get; set; }

        public int getNumberOfStudents()
        {
            return numberOfStudents;
        }

        public void Add(Student student)
        {
            Node<Student> node = new Node<Student>(student);

            if (head == null)
            {
                head = node;
            }
            else
            {
                tail.Next = node;
            }
            tail = node;
            numberOfStudents++;
        }

        public Node<Student> GetNode(int index)
        {
            Node<Student> current = head;
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
            Node<Student> current = head;
            int k = 0;
            while (k < index)
            {
                current = current.Next;
                k++;
            }
            if (k == 0)
            {
                if (head.Next != null)
                {
                    head = head.Next;
                }
                else
                {
                    head = null;
                }
            }
            else if (k == numberOfStudents - 1)
            {
                tail = null;
            }
            else
            {
                current.Next = current.Next.Next;
            }
            numberOfStudents--;
        }

        public bool isEmptyGroup()
        {
            return numberOfStudents == 0;
        }

        public void doClear()
        {
            head = null;
            tail = null;
            numberOfStudents = 0;
        }
        public void addToHead(Student student)
        {
            Node<Student> node = new Node<Student>(student);
            node.Next = head;
            head = node;
            if (numberOfStudents == 0)
            {
                tail = head;
            }
            numberOfStudents++;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator)GetEnumerator();
        }
        IEnumerator<Student> GetEnumerator()
        {
            Node<Student> current = head;
            while (current != null)
            {
                yield return current.student;
                current = current.Next;
            }
        }

    }

}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace UVP_311LinkedList
{
    public class LinkedList<Student> : IEnumerable<Student>
    {
        Node<Student> head;
        Node<Student> tail;
        int numberOfStudents;

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
        public bool Remove(Student del)
        {
            Node<Student> current = head;
            Node<Student> previous = null;

            while (current != null)
            {
                if (current.student.Equals(del))
                {
                    if (previous != null)
                    {
                        previous.Next = current.Next;

                        if (current.Next == null)
                            tail = previous;
                    }
                    else
                    {
                        head = head.Next;

                        if (head == null)
                            tail = null;
                    }
                    numberOfStudents--;
                    return true;
                }

                previous = current;
                current = current.Next;
            }
            return false;
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
        public bool isContains(Student student)
        {
            Node<Student> current = head;
            while (current != null)
            {
                if (current.student.Equals(student))
                {
                    return true;
                }
                current = current.Next;
            }
            return false;
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



        IEnumerator<Student> GetEnumerator()
        {
            Node<Student> current = head;
            while (current != null)
            {
                yield return current.student;
                current = current.Next;
            }
        }

        IEnumerator<Student> IEnumerable<Student>.GetEnumerator()
        {
            yield return (Student)((IEnumerable)this).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }

}

using System;
using System.Collections.Generic;
using System.Text;

namespace UVP_311LinkedList
{
    public class Node<Student>
    {
        public Student student { get; set; }
        public Node<Student> Next { get; set; }

        public Node(Student student_)
        {
            student_ = student;
        }
    }
}

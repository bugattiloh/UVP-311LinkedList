using System;
using System.Collections.Generic;
using System.Text;

namespace UVP_311LinkedList
{
    class Node<Student>
    {
        public Node(Student student_)
        {
            student = student_;
        }
        public Student student { get; set; }
        public Node<Student> Next { get; set; }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace UVP_311LinkedList
{
    public class UniversityGroup : IEnumerable<Student>
    {
        public LinkedList<Student> students;
        public int numberOfStudents => students.Size;

        public UniversityGroup()
        {
            students = new LinkedList<Student>();
        }

        public void AddStudent(Student s)
        {
            students.Add(s);
        }

        public void RemoveStudent(int index)
        {
            students.Remove(index);
        }

        public void CleanGroup()
        {
            students.doClear();
        }

        public bool IsEmptyGroup()
        {
            return students.isEmptyList();
        }

        public IEnumerator<Student> GetEnumerator()
        {
            return students.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        public void ShowGroup()
        {
            foreach (var item in students)
            {
                item.ShowInfo();
            }
        }
    }
}

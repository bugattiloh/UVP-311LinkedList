using System;
using System.Collections.Generic;
using System.Text;

namespace UVP_311LinkedList
{
    class Student
    {
        string Name { get; set; }
        string Surname { get; set; }

        public Student()
        {
            Name = "";
            Surname = "";
        }
        public Student(string name_,string surname_)
        {
            Name = name_;
            Surname = surname_;
        }

        public void showInfo()
        {
            Console.WriteLine(Name + " " + Surname);
        }



    }
}

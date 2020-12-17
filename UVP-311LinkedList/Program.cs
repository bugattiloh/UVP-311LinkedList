using System;

namespace UVP_311LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            var group = new UniversityGroup();

            group.AddStudent(new Student("Ekaterina", "Antonova"));
            group.AddStudent(new Student("Aphonina", "Anastasia"));
            group.AddStudent(new Student("Bagian", "Grigory"));
            group.AddStudent(new Student("Galaev", "Evgeniy"));
            group.AddStudent(new Student("Gorodnikov", "Alexander"));
            group.AddStudent(new Student("Doroshenko", "Petr"));
            group.AddStudent(new Student("Zamanov", "Dmitry"));
            group.AddStudent(new Student("Karpuhin", "Mihail"));
            group.AddStudent(new Student("Kozlov", "Artem"));
            group.AddStudent(new Student("Mashukov", "Ratmir"));
            group.AddStudent(new Student("Medvedev", "Alexey"));
            group.AddStudent(new Student("Melnik", "Anastasia"));
            group.AddStudent(new Student("Nepryahina", "Alena"));
            group.AddStudent(new Student("Novopasheniy", "Maxim"));
            group.AddStudent(new Student("Sinitsa", "Egor"));
            group.AddStudent(new Student("Skvortsov", "Denis"));
            group.AddStudent(new Student("Tarberdyev", "Sergey"));
            group.AddStudent(new Student("Tolkunov", "Dmitry"));
            group.AddStudent(new Student("Yuhanson", "Mihail"));


            Console.WriteLine(group.numberOfStudents);


            group.ShowGroup();


            group.RemoveStudent(5);
            Console.WriteLine("\nPetya deleted,RIP\n");
            group.ShowGroup();
            Console.WriteLine(group.numberOfStudents);


            group.CleanGroup();
            Console.WriteLine(group.numberOfStudents);
        }
    }
}

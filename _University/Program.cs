using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _University
{
    class Program
    {
        static void Main(string[] args)
        {
            IStudentService student = new StudentRepository();
            student.Add(new Student("Levon",22));
            student.Add(new Student("Levon1",23));
            student.Add(new Student("Levon2",24));
            student.Add(new Student("Levon3",25));
            student.Add(new Student("Levon4",26));
            var students= student.GetAll();
            student.Remove(students[0]);
            student.Show(students);
            students[1]._name = "hahaha";
            student.Update(students[1]);
            student.Show(students);
            ITeacherRepository teacher = new TeacherRepository();
            teacher.Add(new Teacher("Tikin1", 60));
            teacher.Add(new Teacher("Tikin2", 61));
            teacher.Add(new Teacher("Tikin3", 62));
            var teachers = teacher.GetAll();
            teacher.Show(teachers);
            teacher.Remove(teachers[1]);
            teachers[1]._age = 100;
            teachers[1]._name = "HHGGFD";
            teacher.Update(teachers[1]);
            teacher.Show(teachers);
            Console.ReadKey();



        }
    }
}

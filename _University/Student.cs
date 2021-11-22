using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _University
{
    public class Student
    {
        public Guid _id;
        public string _name;
        public int _age;
        public Teacher _teacher;

        public Student()
        {
            _id = Guid.NewGuid();
        }

        public Student(string name, int age)
        {
            _id = Guid.NewGuid();
            _name = name;
            _age = age;
        }
    }
}

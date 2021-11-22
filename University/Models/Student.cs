using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University.Models
{
   public  class StudentModel
    {
        public StudentModel(string name, ushort age)
        {
            _id = Guid.NewGuid();
            _name = name;
            _age = age;
        }
        public Guid _id;
        public string _name;
        public ushort _age;
        public string _subject;
        public TeacherModel _teacher;
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _University
{
    public interface IStudentService
    {
        void Update(Student model);
        void Add(Student model);
        List<Student> GetAll();
        void Remove(Student model);
        Student Get(Guid id);
    }
}

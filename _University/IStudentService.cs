using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _University
{
    public interface  IStudentService:IBaseService<Student>
    {
        List<Student> GetAllByTeacher(Guid id);
        void Remove(Student model);
        void Update(Student model);
        void Show(List<Student> models);
    }

}

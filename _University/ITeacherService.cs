using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _University
{
    public interface ITeacherService
    {
        void Add(Teacher model);
        Teacher Get(Guid id);
        List<Teacher> GetAll();
        void Remove(Teacher model);
        void Update(Teacher model);
    }
}

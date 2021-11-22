using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _University
{
    public interface  ITeacherService:IBaseService<Teacher>
    {
        Teacher Get(Guid id);
        void Remove(Teacher model);
        void Update(Teacher model);
        void Show(List<Teacher> models);
    }
}

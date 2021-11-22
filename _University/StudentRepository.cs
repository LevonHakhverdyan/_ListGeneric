using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _University
{
    public class StudentRepository : BaseRepository<Student>,IStudentRepository
    {
        public override Student Get(Guid id)
        {
            return models.FirstOrDefault(x => x._id == id);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _University
{
    public class TeacherRepository : BaseRepository<Teacher>, ITeacherRepository
    {
        public override Teacher Get(Guid id)
        {
            return models.FirstOrDefault(x => x._id == id);
        }
      
    }
}

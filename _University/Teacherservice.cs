using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _University
{
    public class Teacherservice:ITeacherService
    {
        private readonly TeacherRepository _teacherRepository;
        public Teacherservice(TeacherRepository teacherRepository)
        {
            _teacherRepository = teacherRepository;
        }

        public void Add(Teacher model)
        {
            _teacherRepository.Add(model);
        }

        public Teacher Get(Guid id)
        {
            return _teacherRepository.Get(id);
        }

        public List<Teacher> GetAll()
        {
            return _teacherRepository.GetAll();
        }

        public void Remove(Teacher model)
        {
            _teacherRepository.Remove(model);
        }

        public void Update(Teacher model)
        {
            var oldTeacher = _teacherRepository.Get(model._id);
            var index = _teacherRepository.IndexOf(oldTeacher);
            _teacherRepository.Update(model, index);
        }
    }
}

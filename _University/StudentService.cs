using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _University
{
    public class StudentService:IStudentService
    {
        private readonly IStudentRepository _studentRepository;
        public StudentService(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public void Add(Student model)
        {
            _studentRepository.Add(model);
        }

        public Student Get(Guid id)
        {
            return _studentRepository.Get(id);
        }

        public List<Student> GetAll()
        {
           return _studentRepository.GetAll();
        }

        public void Remove(Student model)
        {
            _studentRepository.Remove(model);
        }

        public void Update(Student model)
        {
            var oldStudent = _studentRepository.Get(model._id);
            var index = _studentRepository.IndexOf(oldStudent);
            _studentRepository.Update(model,index);
        }
    }
}

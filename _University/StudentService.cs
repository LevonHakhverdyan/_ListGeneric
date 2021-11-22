using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _University
{
    public class StudentService : BaseService<Student>,IStudentService
    {

        
        public List<Student> GetAllByTeacher(Guid id)
        {
            List<Student> stList = new List<Student>();
            for (int i = 0; i < models.Count; i++)
            {
                if (models[i]._teacher._id == id)
                {
                    stList.Add(models[i]);
                }
            }
            return stList;
        }



        public void Update(Student model)
        {
            for (int i = 0; i < models.Count; i++)
            {
                if (models[i]._id == model._id)
                {
                    models[i] = model;
                }
            }
        }
        public void Show(List<Student> models)
        {
            for (int i = 0; i < models.Count; i++)
            {
                Console.WriteLine($"Name: {models[i]._name}\n Age:{models[i]._age}\n Id:{models[i]._id}\n");
            }
        }

    }
}

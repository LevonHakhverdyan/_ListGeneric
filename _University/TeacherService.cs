using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _University
{
    public class TeacherService : BaseService<Teacher>, ITeacherService
    {

        
        public Teacher Get(Guid id)
        {
            for (int i = 0; i < models.Count; i++)
            {
                if (models[i]._id == id)
                    return models[i];
            }
            return default(Teacher);
        }

        public void Remove(Teacher model)
        {
            models.Remove(model);
        }

        public void Update(Teacher model)
        {
            for (int i = 0; i < models.Count; i++)
            {
                if (models[i]._id == model._id)
                {
                    models[i] = model;
                }
            }
        }
        public void Show(List<Teacher> models)
        {
            for (int i = 0; i < models.Count; i++)
            {
                Console.WriteLine($"Name: {models[i]._name}\n Age:{models[i]._age}\n Id:{models[i]._id}\n");
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _University
{
    public class BaseRepository<T> : IBaseRepository<T>
    {
        public BaseRepository()
        {
            models = new List<T>();
        }
        public List<T> models;
        public void Update(T model, int index)
        {
            models[index] = model;
        }
        public virtual void Add(T model)
        {
            models.Add(model);
        }
        public virtual List<T> GetAll()
        {
            return models;
        }
        public virtual  void Remove(T model)
        {
            models.Remove(model);
        }
        public int IndexOff(T model)
        {
            return models.IndexOf(model);
        }
        public virtual T Get (Guid id)
        {
            throw new NotImplementedException();
        }

    }
}

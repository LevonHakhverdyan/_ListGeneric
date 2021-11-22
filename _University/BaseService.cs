using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _University
{
   public class BaseService<T>:IBaseService<T>
    {
        public static List<T> models = new List<T>();
        
        public virtual  void Add(T model)
        {
            models.Add(model);
        }
        public virtual  List<T> GetAll()
        {
            return models;
        }
        public void Remove(T model)
        {
            models.Remove(model);
        }

        //public void Update(T model)
        //{
        //    for (int i = 0; i < models.Count; i++)
        //    {
        //        if (models[i]._id == model._id)
        //        {
        //            models[i] = model;
        //        }
        //    }
        //}
        //public void Show(List<T> models)
        //{
        //    for (int i = 0; i < models.Count; i++)
        //    {
        //        Console.WriteLine($"Name: {models[i]._name}\n Age:{models[i]._age}\n Id:{models[i]._id}\n");
        //    }
        //}

    }
}

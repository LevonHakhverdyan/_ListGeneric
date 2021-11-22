using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _University
{
    public interface  IBaseService<T>
    {
        void Add(T model);
        List<T> GetAll();
    }
}

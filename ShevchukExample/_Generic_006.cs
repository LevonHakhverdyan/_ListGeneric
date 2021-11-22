using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShevchukExample
{
    public class _Generic_006
    {
        public abstract class Shape { }
        public class Circle : Shape { }
        public interface IContainer<out T>
        {
            T Figure { get;  }
        }
        public class Container<T> : IContainer<T>
        {
            private T _figure; 
            public Container(T figure)
            {
                _figure = figure;
            }
            public T Figure
            {
                get { return _figure; }
            }
        }
       
    }
}

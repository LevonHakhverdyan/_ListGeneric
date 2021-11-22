using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShevchukExample
{
    public class _Generic_004
    {
        public abstract class Shape { }
        public class Circle : Shape { }
        public interface IContainer<T>
        {
            T Figure { get; set; }
        }
        public class Container<T> : IContainer<T>
        {
            public T Figure { get; set; }
            public Container (T figure)
            {
                Figure = figure;
            }
        }
    }
}

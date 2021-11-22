using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShevchukExample
{
     class _Generic_001 <T>
    {
        public T field;
        public void Method()
        {
            Console.WriteLine(field.GetType());
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShevchukExample
{
    public class _Generic_003
    {
        public void Method<T>(T argument)
        {
             T variable = argument;
            Console.WriteLine(variable);
        }
    }
}

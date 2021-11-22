using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShevchukExample
{
    public class _Generic_002<TYPE1,TYPE2,TYPE3>
    {
        private TYPE1 _vairable1;
        private TYPE2 _vairable2;
        private TYPE3 _vairable3;

        public _Generic_002(TYPE1 argument1,TYPE2 argument2, TYPE3 argument3)
        {
            _vairable1 = argument1;
            _vairable2 = argument2;
            _vairable3 = argument3;

        }
        public TYPE1 Variable1 
        {
            get { return _vairable1; }
            set { _vairable1 = value; }
        }
        public TYPE2 Variable2 
        {
            get { return _vairable2; }
            set { _vairable2 = value; } 
        }
        public TYPE3 Variable3
        {
            get { return _vairable3; }
            set { _vairable3 = value; }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ShevchukExample._Generic_004;
using static ShevchukExample._Generic_005;
using Shape = ShevchukExample._Generic_005.Shape;
using Shape1 = ShevchukExample._Generic_006.Shape;

namespace ShevchukExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------------------_Generic_001----------------------------");
            _Generic_001<int> instance1 = new _Generic_001<int>();
            instance1.Method();
            _Generic_001<long> instance2 = new _Generic_001<long>();
            instance2.Method();
            _Generic_001<string> instance3 = new _Generic_001<string>();
            instance3.field = "ABC";
            instance3.Method();
            Console.WriteLine("---------------------_Generic_002----------------------------");
            _Generic_002<int, int,int> instance4 = new _Generic_002<int, int,int>(1,2,3);
            Console.WriteLine(instance4.Variable1 + instance4.Variable2 + instance4.Variable3);
            _Generic_002<string, int,int> instance5 = new _Generic_002<string, int,int>("Number ",1,2);
            Console.WriteLine($"{instance5.Variable1}  {instance5.Variable2 + instance5.Variable3}");
            _Generic_002<string, string,char> instance6 = new _Generic_002<string, string,char>("Hello ", "World ",'!');
            Console.WriteLine(instance6.Variable1 + instance6.Variable2 + instance6.Variable3);
            Console.WriteLine("---------------------_Generic_003----------------------------");
            _Generic_003 instance7 = new _Generic_003();
            instance7.Method<string>("Hello World");
            instance7.Method("Hello World!!!");

            Console.WriteLine("---------------------_Generic_004----------------------------");
            _Generic_004.Circle circle = new _Generic_004.Circle();
            _Generic_004.IContainer<_Generic_004.Circle> container = new _Generic_004.Container<_Generic_004.Circle>(circle);
            Console.WriteLine(container.Figure.ToString());

            Console.WriteLine("---------------------_Generic_005----------------------------");
            _Generic_005.Circle circle1 = new _Generic_005.Circle();
            _Generic_005.IContainer<Shape> container1 = new _Generic_005.Container<Shape>(circle1);
            Console.WriteLine(container1.Figure.ToString());

            Console.WriteLine("---------------------_Generic_006----------------------------");
            _Generic_006.Circle circle2 = new _Generic_006.Circle();
            _Generic_006.IContainer<Shape1> container2 = new _Generic_006.Container<_Generic_006.Circle>(circle2);
            Console.WriteLine(container2.Figure.ToString());

            Console.ReadKey();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _ListGeneric
{
    class Program
    {
        static void Main(string[] args)
        {
            _ArrayList arrayList = new _ArrayList();
            arrayList.Add(23);
            arrayList.Add("hhdh");
            arrayList.Add(5);
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }
            
            Console.ReadKey();

        }
    }
}

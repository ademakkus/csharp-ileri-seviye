using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Overload ob = new Overload();
            Console.WriteLine(ob.OvlDemo(1.1, 2.1));
            Console.WriteLine(ob.OvlDemo(12,21));
            Console.ReadLine();
        }
    }
}

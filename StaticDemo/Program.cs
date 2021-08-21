using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(StaticDemoClass.staticVal.ToString());
            StaticDemoClass.staticVal = 8;
            Console.WriteLine(StaticDemoClass.ValDiv2());
            Console.ReadKey();
        }
    }
}

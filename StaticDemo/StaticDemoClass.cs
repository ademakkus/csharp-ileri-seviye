using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticDemo
{
    class StaticDemoClass
    {
        public int denom = 3;
        public static int staticVal = 100;
        public void NonStaticMethod() { 
            Console.WriteLine("Inside nonstatic method"); 
        }
        public static int ValDiv2()
        {
            return staticVal / 2;
        }
    }
}

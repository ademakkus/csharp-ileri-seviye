using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _010_OperatorOverload_RelationalOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            ThreeD t1 = new ThreeD(10, 10, 110);
            ThreeD t2 = new ThreeD(9, 9, 10);
            if(t1>t2)
                Console.WriteLine("t1 >t2");
            else
                Console.WriteLine("t2 >t1");
            Console.ReadKey();
        }
    }
}

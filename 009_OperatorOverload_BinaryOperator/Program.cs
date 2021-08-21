using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _009_OperatorOverload_BinaryOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            ThreeD t1 = new ThreeD(1,2,3);
            ThreeD t2 = new ThreeD(10,10,10);
            ThreeD t3 = new ThreeD();
            ThreeD t4 = new ThreeD();
            Console.WriteLine("Here is t1:");
            t1.Show();
           Console.WriteLine("Here is t2:");
            t2.Show();
           Console.WriteLine("Here is t3:");
            t3.Show();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            t3 = t1 + t2;
            Console.WriteLine("Here is new t1+t2=t3:");
            t3.Show();
            t3 = t1 + t2 + t3;
            Console.WriteLine("Here is new t1+t2+t3=");
            t3.Show();
            Console.WriteLine();
            t4 = t1 - t2;
            Console.WriteLine("Here is t4=t1-t2");
            t4.Show();
            Console.WriteLine();
            t4 = -t4;
            Console.WriteLine("Here is (-)t4=");
            t4.Show();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            //++
            Console.WriteLine("++ operator");
            Console.WriteLine("Here is t1++:");
            t1 = t1++;
            t1.Show();
            Console.WriteLine("Here is t2++:");
            t2 = t2++;
            t2.Show();
            Console.WriteLine("Here is t3:");
            
            t3.Show();
            Console.WriteLine("Here is t3++:");
            t3++.Show();
            Console.WriteLine();
            //--

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("-- operator");
            Console.WriteLine("Here is t1--:");
            t1--.Show();
            Console.WriteLine("Here is t2--:");
            t2--.Show();
            Console.WriteLine("Here is t3--:");
            t3--.Show();
            //t1+int i
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("** op + int operator ***");
            Console.WriteLine("Here is t1+10=:");
            t1 = t1 + 10;
            t1.Show();
            Console.WriteLine("Here is t2+10:");
            t2 = t2 +10;
            t2.Show();
            Console.WriteLine("Here is t3+10:");
            t3 = t3 + 10;
            t3.Show();
        //t1-int i
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("** op - int operator ***");
            Console.WriteLine("Here is t1-10=:");
            t1 = t1 -10;
            t1.Show();
            Console.WriteLine("Here is t2+10:");
            t2 = t2 - 10;
            t2.Show();
            Console.WriteLine("Here is t3+10:");
            t3 = t3 - 10;
            t3.Show();
        
           
           


            Console.ReadKey();
        }
    }
}

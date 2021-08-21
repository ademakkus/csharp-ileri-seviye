using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadDemo
{
    class Overload
    {
        /// <summary>
        /// parametresiz overload metodu
        /// </summary>
        public void OvlDemo()
        {
            Console.WriteLine("No paramters");
        }
        /// <summary>
        /// tek parametreli overload metodu
        /// </summary>
        /// <param name="a">int a</param>
        public void OvlDemo(int a)
        {
            Console.WriteLine("One paramter"+a);
        }
        /// <summary>
        /// double tipinde iki parametre alan overload metodu
        /// </summary>
        /// <param name="a">double</param>
        /// <param name="b">double </param>
        /// <returns></returns>
        public double OvlDemo(double a,double b)
        {
            Console.WriteLine("Two double parameters: "+a+" ve "+b);
            return a + b;
        }
        public int OvlDemo(int a, int b)
        {
            Console.WriteLine("Two int parameters: " + a + " ve " + b);
            return a + b;
        }

    }
}

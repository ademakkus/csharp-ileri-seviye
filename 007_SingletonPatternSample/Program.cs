using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _007_SingletonPatternSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton s1 = Singleton.Instance();
            Singleton s2 = Singleton.Instance();
            if(s1==s2)
                Console.WriteLine("Objeler aynı.");
            Console.Write("s1  hash code:");
            Console.WriteLine(s1.GetHashCode());
            Console.Write("s2  hash code:");
            Console.WriteLine(s2.GetHashCode());
            Console.WriteLine(s1.Equals(s2));
            
            Console.ReadKey();

        }
    }
}

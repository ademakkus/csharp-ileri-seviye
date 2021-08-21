using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_DestructorExample
{
    
    class DestructSample
    {
        public int x;
        public DestructSample(int i)
        {
            x = i;
        }
        ~DestructSample()
        {
            Console.WriteLine("Destrcuting :"+x);
        }
        public void Generator(int i)
        {
            DestructSample o = new DestructSample(i);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            DestructSample ob = new DestructSample(0);
            for (int i = 1; i < 1000000; i++)
            {
                ob.Generator(i);
            }
            Console.WriteLine("Done");
            Console.ReadKey();
        }
    }
}

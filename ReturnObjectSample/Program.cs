using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReturnObjectSample
{

    class Program
    {
        static void Main(string[] args)
        {
            Rect r1 = new Rect(4, 5);
            Console.WriteLine("Area of r1:"+r1.Area());
            Console.WriteLine();
            Rect r2 = new Rect(4, 5);
            Console.WriteLine("Area of r2:"+r2.Area());
           
            r2=r1.Enlarge(3); 
            Console.WriteLine("Area of r2 after enlarge 3:"+r2.Area());
            Console.WriteLine();
            int i, j;

            //FactoryClass rectangleFactory = new FactoryClass();
            //for (i = 0,j=10; i < 10; i++,j--)
            //{
            //    Rect rect = rectangleFactory.Factory(i, j);
            //    Console.WriteLine(rect.Area());
            //}
            
            //static FactoryClass a göre
            for (i = 0,j=10; i < 10; i++,j--)
            {
                Rect rect = FactoryClass.Factory(i, j);
                Console.WriteLine(rect.Area());
            }
            Console.ReadKey();
        }
    }
}

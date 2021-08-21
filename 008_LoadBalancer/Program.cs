using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _008_LoadBalancer
{
    class Program
    {
        static void Main(string[] args)
        {
            LoadBalancer lb1 = LoadBalancer.GetLoadBalancer();
            LoadBalancer lb2 = LoadBalancer.GetLoadBalancer();
            LoadBalancer lb3 = LoadBalancer.GetLoadBalancer();
            LoadBalancer lb4 = LoadBalancer.GetLoadBalancer();
            LoadBalancer lb5 = LoadBalancer.GetLoadBalancer();
            LoadBalancer lb6 = LoadBalancer.GetLoadBalancer();
            if(lb1==lb2&&lb2==lb3&&lb3==lb4&&lb4==lb5&&lb5==lb6)
                Console.WriteLine("objelerin hepsi aynı.");
            for (int i = 0; i < 15; i++)
            {
                Console.WriteLine(lb1.Server);
            }
            Console.ReadKey();
        }
    }
}

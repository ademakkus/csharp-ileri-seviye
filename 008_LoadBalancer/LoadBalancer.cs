using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _008_LoadBalancer
{
    class LoadBalancer
    {
        private static LoadBalancer instance;
        private ArrayList servers = new ArrayList();
        private Random random = new Random();
        private LoadBalancer()
        {
            servers.Add("Server 1");
            servers.Add("Server 2");
            servers.Add("Server 3");
            servers.Add("Server 4");
            servers.Add("Server 5");
            servers.Add("Server 5");
        }
        public static LoadBalancer GetLoadBalancer()
        {
            if (instance == null)
                instance = new LoadBalancer();
            return instance;
        }
        public string Server
        {
            get
            {
                int r = random.Next(servers.Count);
                return servers[r].ToString();
            }
        }
        
    }
}

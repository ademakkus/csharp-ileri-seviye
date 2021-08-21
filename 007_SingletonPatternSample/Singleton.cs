using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _007_SingletonPatternSample
{
    class Singleton
    {
        private static Singleton instance;
        private Singleton()
        {
        }
        public static Singleton Instance()
        {
            if (instance == null)
                instance = new Singleton();
            return instance;
        }
    }
}

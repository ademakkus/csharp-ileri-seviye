using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReturnObjectSample
{
    class FactoryClass
    {
        
        //public Rect Factory(int i,int j)
        //{
        //    Rect aRect = new Rect(i, j);
        //    return aRect;
        //}
        public static Rect Factory(int i,int j)
        {
            Rect aRect = new Rect(i, j);
            return aRect;
        }
    }
}

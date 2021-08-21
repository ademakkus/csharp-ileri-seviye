using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReturnObjectSample
{
    class Rect
    {
        private int width;
        int height;
        public Rect(int w,int h)
        {
            this.width = w;
            this.height = h;
        }
        public int Area()
        {
            return width * height;
        }
        public Rect Enlarge(int factor)
        {
            return new Rect(width * factor, height * factor);
        }
    }
    
}

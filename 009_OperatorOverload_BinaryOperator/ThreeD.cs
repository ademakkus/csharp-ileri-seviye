using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _009_OperatorOverload_BinaryOperator
{
    class ThreeD
    {
        int x, y, z;
        //public ThreeD()
        //{
        //    x = y = z = 0;
        //}
        //yerine aşağıdaki yazılabilir
         public ThreeD():this(0,0,0)
        {
            //   x = y = z = 0;
            //Console.WriteLine("parametresiz");
        }

        public ThreeD(int i,int j,int k)
        {
            this.x = i;
            this.y = j;
            this.z = k;
           // Console.WriteLine("parametreliii");
        }
        public override string ToString()
        {
            return (x+", "+y+", "+z);
        }
        public void Show()
        {
            Console.WriteLine(x + ", " + y + ", " + z);
        }
        //+ operator
        public static ThreeD operator +(ThreeD op1, ThreeD op2)
        {
            ThreeD result = new ThreeD();
            result.x = op1.x + op2.x;
            result.y = op1.y + op2.y;
            result.z = op1.z + op2.z;

            return result;
        }
        //++ operator
        public static ThreeD operator ++(ThreeD op)
        {
            ThreeD result = new ThreeD();
            result.x = op.x++;
            result.y = op.y++;
            result.z = op.z ++;

            return result;
        }
        // -operator
        public static ThreeD operator -(ThreeD op)
        {
            ThreeD result = new ThreeD();
            result.x = -op.x;
            result.y = -op.y;
            result.z = -op.z;

            return result;
        }
        //op+int
        public static ThreeD operator +(ThreeD op1,int op2)
        {
            ThreeD result = new ThreeD();
            result.x = op1.x+op2;
            result.y = op1.y+op2;
            result.z = op1.z+op2;

            return result;
        }
        //op-int
        public static ThreeD operator -(ThreeD op1,int op2)
        {
            ThreeD result = new ThreeD();
            result.x = op1.x-op2;
            result.y = op1.y-op2;
            result.z = op1.z-op2;

            return result;
        }
        
        // -operator
        public static ThreeD operator --(ThreeD op)
        {
            ThreeD result = new ThreeD();
            result.x = op.x--;
            result.y = op.y--;
            result.z = op.z --;

            return result;
        }

        public static ThreeD operator-(ThreeD op1,ThreeD op2)
        {
            ThreeD result = new ThreeD();
            result.x = op1.x - op2.x;
            result.y = op1.y - op2.y;
            result.z = op1.z - op2.z;
            return result;
        }

    }
}

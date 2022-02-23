using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ArithmeticCon.Arithmetics
{
    //public class Int32Arithmetic : IArithmetic<int>
    public class Int32Arithmetic : IArithmetic
    {

        public object Add(object o1, object o2)
        {
            return (object)((int)o1 + (int)o2);
        }

        public object Subtract(object o1, object o2)
        {
            return (int)o1 - (int)o2;
        }

        public object Multiply(object o1, object o2)
        {
            return (int)o1 * (int)o2;
        }

    }
}

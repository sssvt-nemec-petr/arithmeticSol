using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ArithmeticCon.Arithmetics
{
    //public class DoubleArithmetic : IArithmetic<double>
    public class DoubleArithmetic : IArithmetic
    {
        public object Add(object o1, object o2)
        {
            return (double)o1 + (double)o2;
        }

        public object Subtract(object o1, object o2)
        {
            return (double)o1 - (double)o2;
        }

        public object Multiply(object o1, object o2)
        {
            return (double)o1 * (double)o2;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ArithmeticCon.BusinessObjects;



namespace ArithmeticCon.Arithmetics
{
    //public class ComplexArithmetic : IArithmetic<Complex>
    public class ComplexArithmetic : IArithmetic
    {
        public object Add(object obj1, object obj2)
        {
            Complex o1 = (Complex)obj1;
            Complex o2 = (Complex)obj2;
            return new Complex(o1.Real + o2.Real, o1.Imaginary + o2.Imaginary);
        }

        public object Subtract(object obj1, object obj2)
        {
            Complex o1 = (Complex)obj1;
            Complex o2 = (Complex)obj2;
            return new Complex(o1.Real - o2.Real, o1.Imaginary - o2.Imaginary);
        }

        public object Multiply(object obj1, object obj2)
        {
            Complex o1 = (Complex)obj1;
            Complex o2 = (Complex)obj2;
            return new Complex(o1.Real * o2.Real - o1.Imaginary * o2.Imaginary, o1.Real * o2.Imaginary + o1.Imaginary * o2.Real);
        }
    }
}

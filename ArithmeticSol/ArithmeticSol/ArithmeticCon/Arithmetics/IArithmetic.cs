using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ArithmeticCon.Arithmetics
{
    //public interface IArithmetic<T>
    public interface IArithmetic
    {

        object Add(object o1, object o2);

        object Subtract(object o1, object o2);

        object Multiply(object o1, object o2);

    }
}

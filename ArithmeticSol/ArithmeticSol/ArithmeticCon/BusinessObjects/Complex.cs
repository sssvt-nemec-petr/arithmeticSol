using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArithmeticCon.BusinessObjects
{
    public struct Complex
    {
        public double Real { get; set; }
        public double Imaginary { get; set; }

        public Complex(double real, double imaginary)
        {
            this.Real = real;
            this.Imaginary = imaginary;
        }


        // 10.5-11.3i
        // 10.5 - 11.3i
        // 10.5 + (-11.3)i
        // 10.5+(-11.3)i
        // -10.5+(-11.3)i
        // +10.5+(-11.3)i
        public static Complex Parse(string s)
        {
            string num = s.Trim();
            num = num.Replace(" ", "");
            int plusPos = num.IndexOf('+');
            if (plusPos == 0)
            {
                plusPos = num.IndexOf('+', 1);
            }
            int minusPos = num.IndexOf('-');
            if (minusPos == 0)
            {
                minusPos = num.IndexOf('-', 1);
            }
            if ( (plusPos != -1) && ((minusPos == -1) || (plusPos < minusPos)) )
            {
                // 10.5+(-11.3)i
                // +10.5+(-11.3)i
                // -10.5+(-11.3)i
                // -10.1 + 2.6i
                string numRe = num.Substring(0, plusPos);
                string numIm = num.Substring(plusPos + 1);
                numIm = numIm.Substring(0, numIm.Length - 1);
                double re = double.Parse(numRe);
                double im = double.Parse(numIm);
                return new Complex(re, im);
            }
            else
            {
                // 10.5-11.3i
                // 3.1 - 4i
                string numRe = num.Substring(0, minusPos);
                string numIm = num.Substring(minusPos + 1);
                numIm = numIm.Substring(0, numIm.Length - 1);
                double re = double.Parse(numRe);
                double im = double.Parse(numIm);
                im = -im;
                return new Complex(re, im);
            }
        }



        public override string ToString()
        {
            return $"{this.Real} + {this.Imaginary}i";
        }

    }
}

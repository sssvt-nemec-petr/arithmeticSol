using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArithmeticCon.Arithmetics
{
    class StringArithmetic : IArithmetic
    {
        public object Add(object o1, object o2)
        {
            return (object)((string)o1 + (string)o2);
        }
        public object Subtract(object o1, object o2)
        {
            string obj1 = o1.ToString();
            string obj2 = o2.ToString();
            string main = null;
            string secondary = null;
            if(obj1 == obj2)
            {
                return (object)null;
            }
            if (obj1.Length > obj2.Length)
            {
                for (int i = 0; i < obj2.Length; i++)
                {
                    int pos = obj1.IndexOf(obj2[i]);
                    if (pos >= 0)
                    {
                        main = obj1.Remove(pos, 1);

                        int pos2 = obj2.IndexOf(obj2[i]);
                        if (pos2 >= 0)
                        {
                            secondary = obj2.Remove(pos2, 1);
                        }
                    }
                }
            }
            else
            {
                for (int i = 0; i < obj1.Length; i++)
                {
                    int pos = obj2.IndexOf(obj1[i]);
                    if (pos >= 0)
                    {
                        main = obj2.Remove(pos, 1);

                        int pos2 = obj1.IndexOf(obj1[i]);
                        if (pos2 >= 0)
                        {
                            if (pos2 == obj1.Length)
                            {
                                secondary = null;
                            }
                            else
                            {
                                secondary = obj1.Remove(pos2, 1);
                            }
                        }
                    }
                }
            }
            return (object)((string)main + (string)secondary);
        }
        public object Multiply(object o1, object o2)
        {
            string obj1 = o1.ToString();
            string obj2 = o2.ToString();
            string result = null;
            for (int i = 0; i < obj1.Length; i++)
            {
                for(int x = 0; x < obj2.Length; x++ )
                {
                    result += obj1[i].ToString() + obj2[x].ToString();
                }
            }
            return (object)result;
        }


    }
}

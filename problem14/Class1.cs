using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace problem14
{
    internal class Class1
    {
        public class calculator<T> where T : struct, IComparable, IFormattable, IConvertible, IComparable<T>, IEquatable<T>
        {
            public delegate T AddDelegate(T a, T b);
            public delegate T SubDelegate(T a, T b);
            public delegate T MulDelegate(T a, T b);
            public delegate T DivDelegate(T a, T b );
            public T addDelegate(T a, T b,AddDelegate total )
            {
                return total(a,b);
            }
            public T subtractDelegate(T a,T b,SubDelegate total)
            {
               return total(a,b);
            }
            public T multiplyDelegate(T a, T b, MulDelegate total)
            {
                return total(a, b);
            }
            public T divideDelegate(T a, T b, DivDelegate total)
            {
                return total(a, b);
            }







        }
    }
}

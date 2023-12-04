using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class GenericsCheck<T>{
        public T Output(T a, T b)
        {
            return (dynamic)a + (dynamic)b;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciLibrary
{
    public class ConsecutiveFibonacci
    {
        public static ulong[] Product(ulong product)
        {
            ulong f = 0;
            ulong fn = 1;
            while(f * fn < product)
            {
                fn = f + fn;
                f = fn - f;
            }

            var fx = f * fn == product ? 1 : 0;
            return new ulong[] { f, fn, (ulong)fx };
        }
    }
}

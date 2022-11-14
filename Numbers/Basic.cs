using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numbers
{
    public static class Basic
    {
        public static bool UnderLimit(decimal number, decimal limit)
            => number < limit;

        public static bool NumbersEqual(decimal a, decimal b, decimal epsilon) 
            =>  (a - b) < epsilon && (a - b) > -epsilon;

        public static Tuple<decimal, decimal> DivMod(decimal a, decimal b) 
            => new Tuple<decimal, decimal>(Math.Floor(a / b), a % b);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numbers
{
    public static class Prime
    {
        public static bool IsPrime(int candidate)
        {
            if (candidate < 2)
            {
                return false;
            }

            for (int i = 2; i < candidate; i++) {
                if (candidate % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}

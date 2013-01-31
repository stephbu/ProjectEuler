using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace ProjectEuler
{
    public class Problem10
    {
        public static void Answer()
        {
            var sumPrimes = Prime.Sequence.TakeWhile(primeNumber => primeNumber < 2000000).Sum();
            Debug.WriteLine(sumPrimes);
        }

    }
}

using System;
using System.Linq;
using System.Numerics;

namespace ProjectEuler
{
    public class Problem25
    {
        public static void GetThousandDigitFibonacci()
        {
            // Skip the first result - sequence is 0,1,1,2 etc...
            var bigFib = Fibonnaci.BigIntegerSequence.Skip(1);
            int count = 0;
            foreach (BigInteger term in bigFib)
            {
                count++;
                System.Diagnostics.Debug.WriteLine("{0} : {1}", new object[]{count, term});
                if (term.ToString().Length == 1000)
                { break; }                                       
            }
            System.Diagnostics.Debug.WriteLine(count);

        }
    }
}

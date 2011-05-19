using System;
using System.Linq;
using System.Numerics;

namespace ProjectEuler
{
    public class Problem25
    {
        public static void GetThousandDigitFibonacci()
        {
            BigInteger thousandDigit = Fibonnaci.BigIntegerSequence.SkipWhile(num => num.ToString().Length < 1000).First();
            System.Diagnostics.Debug.WriteLine(thousandDigit);
        }
    }
}

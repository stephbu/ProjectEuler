using System.Collections.Generic;
using System.Numerics;

namespace ProjectEuler
{
    public class Fibonnaci
    {
        public static IEnumerable<int> Sequence
        {
            get
            {
                yield return 0;
                yield return 1;
                int n2 = 0;
                int n1 = 1;
                int nextNumber;
                while (true)
                {
                    nextNumber = n1 + n2;
                    yield return nextNumber;
                    n2 = n1;
                    n1 = nextNumber;
                }

            }
        }

        public static IEnumerable<BigInteger> BigIntegerSequence
        {
            get
            {
                yield return 0;
                yield return 1;
                BigInteger n2 = 0;
                BigInteger n1 = 1;
                BigInteger nextNumber;
                while (true)
                {
                    nextNumber = n1 + n2;
                    yield return nextNumber;
                    n2 = n1;
                    n1 = nextNumber;
                }

            }
        }

    }
}

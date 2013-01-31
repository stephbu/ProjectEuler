using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler
{
    public static class LongExtensions
    {
        public static IEnumerable<long> Factors(this long number)
        {
            int factorCount = 0;
            try
            {
                factorCount++;
                yield return 1;

                if (number == 1)
                {
                    yield break;
                }

                long index = 2;

                int ceiling = (int)Math.Sqrt(number);

                while (index <= ceiling)
                {
                    if (number % index == 0)
                    {
                        factorCount++;
                        yield return index;

                        long inverse = number / index;
                        if (inverse != index)
                        {
                            factorCount++;
                            yield return inverse;
                        }
                    }
                    index++;
                }
                factorCount++;
                yield return number;
            }
            finally
            {
                System.Diagnostics.Debug.WriteLine("Factors:{0}", factorCount);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler
{
    public class Problem14
    {
        public static void LargestChain()
        {
            int longestLength = 0;
            long longest = 0;
            foreach (long seed in Enumerable.Range(1, 999999))
            {
                int length = Sequence(seed).Count();
                if (length > longestLength)
                {
                    longestLength = length;
                    longest = seed;
                }
            }
            System.Diagnostics.Debug.WriteLine(longest);
        }

        public static IEnumerable<long> Sequence (long seed)
        {
            yield return seed;
            while (seed > 1)
            {
                if (seed % 2 == 0)
                {
                    seed = seed / 2;
                }
                else
                {
                    seed = (3 * seed) + 1; 
                }
                if (seed < 1)
                {
                    throw new ArgumentOutOfRangeException();
                }
                yield return seed;
            }
        }

    }
}

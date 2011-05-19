using System.Collections.Generic;
using System.Linq;

namespace ProjectEuler
{
    public class Prime
    {
        public static IEnumerable<long> Sequence
        {
            get
            {
                var odds = from n in Enumerable.Range(0, int.MaxValue) select 3 + (long)n * 2;

                return (new[] { 2L }).Concat( from p in odds where !odds.TakeWhile(odd => odd * odd <= p).Any(odd => p % odd == 0) select p);

            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler
{
    public class Problem12
    {
        public static IEnumerable<long> TriangleNumberSequence()
        {
            long seed = 0;
            long index = 0;
            while (true)
            {
                index++;
                seed = seed + index;
                System.Diagnostics.Debug.WriteLine(seed);
                yield return seed;
            }
        }

        public static void Answer()
        {
            var answer = TriangleNumberSequence().First(triangleNumber => triangleNumber.Factors().Count() > 500);
            System.Diagnostics.Debug.WriteLine(answer);
        }
    }
}
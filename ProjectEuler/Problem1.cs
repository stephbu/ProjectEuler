using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler
{

    class Problem1
    {
        public int Sum()
        {
            return NaturalNumbersDivisibleBy3or5(1, 1000).Sum();
        }

        public IEnumerable<int> NaturalNumbersDivisibleBy3or5(int start, int end)
        {
            for (int number = start; number < end; number++)
            {
                if ((number % 3 == 0) || (number % 5 == 0))
                {
                    System.Diagnostics.Debug.WriteLine(number);
                    yield return number;
                }
            }
        }
    }

}

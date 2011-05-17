using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler
{
    class Fibonnaci
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

    }
}

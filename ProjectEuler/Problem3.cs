using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler
{
    public class Problem3
    {
        public void FindPrimeFactor()
        {
            foreach (long prime in Prime.Sequence.TakeWhile(num => num < 600851475143))
            {
                if (600851475143 % prime == 0)
                {
                    System.Diagnostics.Debug.WriteLine(prime);
                }
            }
        }
    }
}

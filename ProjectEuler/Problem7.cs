using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler
{
    public class Problem7
    {
        public static void Prime10001()
        {
            long prime10001 = Prime.Sequence.Take(10001).Last();
            System.Diagnostics.Debug.WriteLine(prime10001);
        }
    }
}

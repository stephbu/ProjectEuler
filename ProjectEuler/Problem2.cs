using System.Linq;

namespace ProjectEuler
{
    class Problem2
    {
        public void Sum()
        {
            int sum = Fibonnaci.Sequence.TakeWhile(num => num < 4000000).Where(num => num % 2 == 0).Sum();
        }
    }
}

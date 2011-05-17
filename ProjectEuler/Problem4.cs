using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler
{
    class Problem4
    {
        public static void GetLargestPalindrome()
        {
            var lhs = Enumerable.Range(100, 899);
            var rhs = Enumerable.Range(100, 899);
            
            // Cartesian join and new derived type
            var product = from left in lhs from right in rhs select new {Left = left, Right = right, LeftTimesRight = (left*right)};
            var palindromes = from candidate in product.OrderByDescending(num => num.LeftTimesRight) where IsPalindrome(candidate.LeftTimesRight.ToString()) select candidate;
            foreach (var palindrome in palindromes)
            {
                System.Diagnostics.Debug.WriteLine("{0} x {1} = {2}", new object[] { palindrome.Left, palindrome.Right,palindrome.LeftTimesRight});
            }
        }

        
        public static bool IsPalindrome(string candidate)
        {
            if(string.IsNullOrEmpty(candidate))
            {
                return false; 
            }

            int tail = candidate.Length - 1;
            int head = 0;

            while(head < tail)
            {
                if(candidate[head] != candidate[tail])
                {
                    return false;
                }
                head++;
                tail--;
            }
            return true;
        }
    }
}

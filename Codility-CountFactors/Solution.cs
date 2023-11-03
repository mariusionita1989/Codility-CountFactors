using System.Runtime.CompilerServices;

namespace Codility_CountFactors
{
    public class Solution
    {
        public const int RANGE_LOWEST_VALUE = 1;
        public const int RANGE_HIGHEST_VALUE = 2147483647;

        [MethodImpl(MethodImplOptions.AggressiveOptimization)]
        public int solution(int N)
        {
            int factors = 0;
            if (N >= RANGE_LOWEST_VALUE && N <= RANGE_HIGHEST_VALUE) 
            {
                int sqrtN = (int)Math.Sqrt(N);
                for (int i = 1; i <= sqrtN; i++)
                {
                    if (N % i == 0)
                        factors += 2; // Increment by 2 for each pair of factors (i and N/i).
                }

                // If N is a perfect square, subtract 1 from the factor count to avoid double-counting.
                if (sqrtN * sqrtN == N)
                    factors--;
            }
            
            return factors;
        }
    }
}

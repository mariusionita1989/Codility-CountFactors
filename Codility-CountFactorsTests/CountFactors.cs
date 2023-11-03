using Codility_CountFactors;

namespace Codility_CountFactorsTests
{
    public class SolutionTests
    {
        [Theory]
        [InlineData(24, 8)]  // N = 24 has 8 factors
        [InlineData(1, 1)]   // N = 1 has only 1 factor
        [InlineData(9, 3)]   // N = 9 has 3 factors (1, 3, and 9)
        [InlineData(16, 5)]  // N = 16 has 5 factors (1, 2, 4, 8, and 16)
        [InlineData(25, 3)]  // N = 25 has 3 factors (1, 5, and 25)
        [InlineData(2147483647, 2)] // N is prime, has only 2 factors (1 and itself)
        public void TestSolution(int N, int expected)
        {
            Solution solution = new Solution();
            int result = solution.solution(N);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(-3)]
        public void TestSolution_OutOfRange(int N)
        {
            Solution solution = new Solution();
            int result = solution.solution(N);
            // Ensure that the result is 0 for out-of-range inputs
            Assert.Equal(0, result);
        }
    }
}
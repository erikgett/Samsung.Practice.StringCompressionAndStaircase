
namespace Samsung.Practice.StringCompressionAndStaircase
{
    public static class Staircase
    {
        public static int CountWays(int n)
        {
            if (n == 0) return 1;
            if (n < 0) return 0;

            return CountWays(n - 1) + CountWays(n - 2) + CountWays(n - 3);
        }
    }
}

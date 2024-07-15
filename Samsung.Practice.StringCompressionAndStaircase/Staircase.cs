// <copyright file="Staircase.cs" company="Samsung">
// Copyright (c) Samsung. All rights reserved.
// Licensed under the NC license. See LICENSE.md file in the project root for full license information.
// </copyright>

namespace Samsung.Practice.StringCompressionAndStaircase
{
    /// <summary> This class provides a method to count the number of ways a child can run up a staircase.</summary>
    public static class Staircase
    {
        /// <summary> This method calculates the number of ways to run up a staircase with 'n' steps. </summary>
        /// <param name="n">number of steps.</param>
        /// <returns>count child ways.</returns>
        public static int CountWays(int n)
        {
            // If the number of steps is 0, there is only one way - not moving.
            if (n == 0)
            {
                return 1;
            }

            // If the number of steps is less than 0, there are no ways.
            if (n < 0)
            {
                return 0;
            }

            // Recursive call to count the ways for (n-1), (n-2), and (n-3) steps.
            return CountWays(n - 1) + CountWays(n - 2) + CountWays(n - 3);
        }
    }
}

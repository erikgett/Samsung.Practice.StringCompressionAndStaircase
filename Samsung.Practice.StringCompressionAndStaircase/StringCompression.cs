// <copyright file="StringCompression.cs" company="Samsung">
// Copyright (c) Samsung. All rights reserved.
// Licensed under the NC license. See LICENSE.md file in the project root for full license information.
// </copyright>

using System.Text;

namespace Samsung.Practice.StringCompressionAndStaircase
{
    /// <summary> String compression extension.</summary>
    public static class StringCompression
    {
        /// <summary>Compress input string.</summary>
        /// <param name="input"><seealso cref="string"/></param>
        /// <returns>Compressed input.</returns>
        public static string Compress(this string input)
        {
            // If the input string is null or empty, return the original string.
            if (string.IsNullOrEmpty(input))
            {
                return input;
            }

            // Initialize a StringBuilder to build the compressed string.
            StringBuilder compressed = new ();

            // Repeating character counter
            int countConsecutive = 0;

            // Loop through each character in the input string.
            for (int i = 0; i < input.Length; i++)
            {
                countConsecutive++;

                // If the current character is the last one or different from the next one,
                // append the current character and its count to the StringBuilder.
                if (i + 1 >= input.Length || input[i] != input[i + 1])
                {
                    compressed.Append(input[i]);
                    compressed.Append(countConsecutive);

                    // Reset the consecutive character count.
                    countConsecutive = 0;
                }
            }

            // Convert the StringBuilder to a string.
            string compressedString = compressed.ToString();

            // Return the compressed string if it's shorter than the original string;
            // otherwise, return the original string.
            return compressedString.Length < input.Length ? compressedString : input;
        }
    }
}

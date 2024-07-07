using System.Text;

namespace Samsung.Practice.StringCompressionAndStaircase
{
    public static class StringCompression
    {
        public static string Compress(this string input)
        {
            if (string.IsNullOrEmpty(input)) return input;

            StringBuilder compressed = new ();
            int countConsecutive = 0;

            for (int i = 0; i < input.Length; i++)
            {
                countConsecutive++;

                if (i + 1 >= input.Length || input[i] != input[i + 1])
                {
                    compressed.Append(input[i]);
                    compressed.Append(countConsecutive);
                    countConsecutive = 0;
                }
            }

            string compressedString = compressed.ToString();
            return compressedString.Length < input.Length ? compressedString : input;
        }
    }
}

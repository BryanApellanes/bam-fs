namespace Bam.Blobs;

public static class StringExtensions
{
    /// <summary>
    /// Splits the value into chunks of the specified length.
    /// </summary>
    /// <param name="value">The value.</param>
    /// <param name="maxLength">The maximum length.</param>
    /// <returns></returns>
    public static IEnumerable<string> SplitByLength(this string value, int maxLength)
    {
        for (int index = 0; index < value.Length; index += maxLength)
        {
            yield return value.Substring(index, Math.Min(maxLength, value.Length - index));
        }
    }
}
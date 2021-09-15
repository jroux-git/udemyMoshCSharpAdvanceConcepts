namespace System
{
    public static class StringExtensions
    {
        public static string Shorten(this string str, int shortenToCharLength)
        {
            if (shortenToCharLength <=0)
            {
                throw new ArgumentOutOfRangeException("shortenToCharLength must be greater than 0");
            }

            return string.Concat(str.Substring(0, shortenToCharLength).Trim(), "...");
        }
    }
}

namespace StringLib
{
    public static class StringExts
    {
        public static bool StartsWithUpperCase(this string str)
        {
            return !string.IsNullOrEmpty(str) && char.IsUpper(str[0]);
        }
    }
}

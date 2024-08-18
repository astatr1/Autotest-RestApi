namespace RestAPI.Framework.Utils
{
    public static class StringExtensions
    {
        public static bool IsEmptyOrEmptyJsonObject(this string str)
        {
            return string.IsNullOrEmpty(str) || str.Trim() == "{}";
        }
    }
}

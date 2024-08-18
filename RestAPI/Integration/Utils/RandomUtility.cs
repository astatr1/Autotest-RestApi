namespace RestAPI.Integration.Utils
{
    public static class RandomUtility
    {
        private readonly static Random random = new();
        public const string UpperCaseLatin = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        public const string LowerCaseLatin = "abcdefghijklmnopqrstuvwxyz";
        public const string UpperCaseCyrillic = "АБВГДЕЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";
        public const string Digits = "0123456789";

        public static string RandomString(int length, string chars)
        {
            return new string(Enumerable.Repeat(chars, length)
                .Select(randomString => randomString[random.Next(randomString.Length)]).ToArray());
        }
    }
}

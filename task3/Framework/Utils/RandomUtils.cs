namespace task3.framework.testing_utils
{
    public class RandomUtils
    {
        private static readonly Random Random = new Random();
        public static string GetRandomText(int length)
        {
            var alphabet = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            var chars = new char[length];
            for (int i = 0; i < length; i++)
            {
                chars[i] = alphabet[Random.Next(alphabet.Length)];
            }
            return new string(chars);
        }
    }
}

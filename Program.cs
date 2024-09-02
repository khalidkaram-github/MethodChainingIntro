namespace MethodChainingIntro
{
    internal class Program
    {

        static void Main()
        {
            var original = "Original";

            var result = original.Append(" new string").Append(" dfghjj").Append(" dadadasd");

            Console.WriteLine(result);

        }
    }
    public static class StringExtensions
    {
        public static string Append(this string source, string str)
        {
            return source + str;
        }

    }
}

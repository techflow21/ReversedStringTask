using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string statement = "Hello World!";
            string finalResult = ReversedMethod(statement);
            Console.WriteLine(finalResult);
        }

        public static string ReversedMethod(string statement)
        {
            string[] words = statement.Split(' ');
            Array.Reverse(words);
            return string.Join(' ', words);
        }
    }
}
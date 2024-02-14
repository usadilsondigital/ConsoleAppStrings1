namespace ConsoleAppStrings1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string phrase = "The quick brown fox jumps over the lazy dog.";
            string[] words = phrase.Split(' ');

            foreach (var word in words)
            {
                System.Console.WriteLine($"<{word}>");
            }



            string phrase1 = "The quick brown    fox     jumps over the lazy dog.";
            string[] words1 = phrase1.Split(' ');

            foreach (var word in words1)
            {
                System.Console.WriteLine($"<{word}>");
            }




        }
    }
}

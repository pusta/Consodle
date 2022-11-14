// See https://aka.ms/new-console-template for more information

namespace Consodle
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            selectWord selectedWord = new selectWord();
            var todayWord = selectedWord.getWord();

            Console.WriteLine(todayWord);
        }
    }
}
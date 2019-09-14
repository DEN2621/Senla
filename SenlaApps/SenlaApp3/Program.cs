using System;

namespace SenlaApp3
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите предложение:");
            Console.Write("> ");
            string[] sentence = Console.ReadLine().Split();
            if (sentence.Length % 10 == 0 || (sentence.Length % 10 >= 5 && sentence.Length % 10 <= 9 || (sentence.Length % 100 >= 11 && sentence.Length % 100 <= 19)))
            {
                Console.WriteLine($"В предложении {sentence.Length} слов");
            }
            else if (sentence.Length % 10 >= 2 && sentence.Length % 10 <= 4)
            {
                Console.WriteLine($"В предложении {sentence.Length} слова");
            }
            else if (sentence.Length % 10 == 1)
            {
                Console.WriteLine($"В предложении {sentence.Length} слово");
            }
            Array.Sort(sentence);
            foreach (string word in sentence)
            {
                Console.Write($"{word} ");
            }
            Console.WriteLine();
            for (int i = 0; i < sentence.Length; ++i)
            {
                char[] letters = sentence[i].ToCharArray();
                letters[0] = char.ToUpper(letters[0]);
                sentence[i] = new string(letters);
            }
            foreach (string word in sentence)
            {
                Console.Write($"{word} ");
            }
            Console.WriteLine();
        }
    }
}

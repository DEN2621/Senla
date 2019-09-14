using System;

namespace SenlaApp4
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите предложение:");
            Console.Write("> ");
            string sentence = Console.ReadLine().ToLower();
            Console.Write("Введите слово: ");
            string word = Console.ReadLine().ToLower();
            for (int i = 0; i < sentence.Length;)
            {
                if (char.IsPunctuation(sentence[i]))
                {
                    sentence = sentence.Remove(i, 1);
                }
                else
                {
                    ++i;
                }
            }
            int count = 0;
            for (int i = 0; i < sentence.Split().Length; ++i)
            {
                if (sentence.Split()[i] == word)
                {
                    ++count;
                }
            }
            if (count % 10 == 0 || count % 10 == 1 || (count % 10 >= 5 && count % 10 <= 9 || (count % 100 >= 11 && count % 100 <= 19)))
            {
                Console.WriteLine($"Слово \"{word}\" встречается в предложении {count} раз");
            }
            else if (count % 10 >= 2 && count % 10 <= 4)
            {
                Console.WriteLine($"Слово \"{word}\" встречается в предложении {count} раза");
            }
        }
    }
}

using System;

namespace SenlaApp5
{
    class Program
    {
        static void Main()
        {
            Console.Write("Введите число: ");
            int n = Convert.ToInt32(Console.ReadLine());
            //Я знаю, что N не должно превышать 100 и могу сделать такое ограничение, но это слишком неинтересно ;)
            for (int i = 0; i <= n; ++i)
            {
                string temp = Convert.ToString(i);
                bool isPalindrome = true;
                for (int j = 0; j <= temp.Length / 2; ++j)
                {
                    if (temp[j] != temp[temp.Length - 1 - j])
                    {
                        isPalindrome = false;
                    }
                }
                if (isPalindrome)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}

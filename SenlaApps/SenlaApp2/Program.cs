using System;

namespace SenlaApp2
{
    class Program
    {
        static void Main()
        {
        start: Console.Write("Введите 2 числа: ");
            string[] input = Console.ReadLine().Split();
            if (!int.TryParse(input[0], out int gcd) || !int.TryParse(input[1], out int number))
            {
                Console.WriteLine("Неверный формат ввода данных!");
                goto start;
            }
            if (number < 0)
            {
                number = -number;
            }
            if (number < gcd)
            {
                for (int i = number; i > 0; i--)
                {
                    if ((number % i == 0) & (gcd % i == 0))
                    {
                        gcd = i;
                        break;
                    }
                }
            }
            else
            {
                for (int i = gcd; i > 0; i--)
                {
                    if ((number % i == 0) & (gcd % i == 0))
                    {
                        gcd = i;
                        break;
                    }
                }
            }
            if (gcd == 1)
            {
                Console.WriteLine("Введённые числа являются взаимно простыми");
                return;
            }
            Console.WriteLine($"Наибольший общий делитель чисел равен {gcd}");
            int lcm = Convert.ToInt32(input[0]) * Convert.ToInt32(input[1]) / gcd;
            Console.WriteLine($"Наименьшее общее кратное чисел равно {lcm}");
        }
    }
}

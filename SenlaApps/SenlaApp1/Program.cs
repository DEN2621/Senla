using System;

namespace SenlaApp1
{
    class Program
    {
        static void Main()
        {
            start: Console.Write("Введите число: ");
            if (!int.TryParse(Console.ReadLine(), out int number))
            {
                Console.WriteLine("Неверный формат ввода данных!");
                goto start;
            }
            if (number < 1)
            {
                Console.WriteLine("Определить, является ли число простым, возможно только для натуральных чисел");
                goto start;
            }
            Boolean isPrime = true;
            switch (number)
            {
                case 1:
                    Console.WriteLine("Введённое число не является ни простым, ни составным");
                    return;
                case 2:
                    Console.WriteLine("Введено чётное простое число");
                    return;
                case 3:
                    Console.WriteLine("Введено нечётное простое число");
                    return;
                default:
                    if (number % 2 == 0)
                    {
                        Console.WriteLine("Введено чётное составное число");
                        return;
                    }
                    else
                    {
                        for (int i = 2; i <= Math.Sqrt(number); ++i)
                        {
                            if (number % i == 0)
                            {
                                isPrime = false;
                                break;
                            }
                            else
                            {
                                continue;
                            }
                        }
                    }
                    break;
            }
            switch (isPrime)
            {
                case true:
                    Console.WriteLine("Введено нечётное простое число");
                    return;
                case false:
                    Console.WriteLine("Введено нечётное составное число");
                    return;
            }
        }
    }
}

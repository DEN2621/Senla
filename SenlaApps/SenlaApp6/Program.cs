using System;

namespace SenlaApp6
{
    class Program
    {
        static int Worth(int mass, Object[] objects, out Object[] backpack)
        {
            int worth = 0;
            Object[] backpackTemp = new Object[0];
            foreach (Object obj in objects)
            {
                if (mass >= obj.Mass)
                {
                    int priceTemp = Worth(mass - obj.Mass, objects, out backpack);
                    if ((priceTemp + obj.Price) > worth)
                    {
                        worth = priceTemp + obj.Price;
                        Array.Resize(ref backpack, backpack.Length + 1);
                        backpack[backpack.Length - 1] = obj;
                        backpackTemp = backpack;
                    }
                }
            }
            backpack = backpackTemp;
            return worth;
        }
        static void Main()
        {
            Object[] stock = new Object[] { new Object(11, 18), new Object(12, 17), new Object(15, 25), new Object(16, 27), new Object(17, 25) };//Список предметов (масса, стоимость)
            int mass = 100;//Вместимость рюкзака
            Console.WriteLine($"Стоимость рюкзака: {Worth(mass, stock, out Object[] backpack)}");
            Console.WriteLine("Содержимое склада:");
            foreach (Object obj in stock)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine("Содержимое рюкзака:");
            foreach (Object obj in backpack)
            {
                Console.WriteLine(obj);
            }
        }
    }
}

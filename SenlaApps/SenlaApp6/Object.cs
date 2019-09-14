using System;

namespace SenlaApp6
{
    class Object
    {
        int mass;
        public override string ToString()
        {
            return $"({Mass}, {Price})";
        }
        public int Mass
        {
            get
            {
                return mass;
            }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Error");
                }
                else
                {
                    mass = value;
                }
            }
        }
        public int Price { get; set; }
        public Object(int mass, int price)
        {
            Mass = mass;
            Price = price;
        }
    }
}
